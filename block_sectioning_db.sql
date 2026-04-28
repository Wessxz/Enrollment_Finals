-- ============================================================
-- BLOCK SECTIONING - Database Update
-- Run this in phpMyAdmin on enrollment_system_db
-- ============================================================

-- 1. Create sections table
CREATE TABLE IF NOT EXISTS `sections` (
  `section_id`    INT(11)      NOT NULL AUTO_INCREMENT,
  `section_name`  VARCHAR(50)  NOT NULL,
  `course`        VARCHAR(50)  NOT NULL,
  `year_level`    VARCHAR(20)  NOT NULL,
  `semester`      VARCHAR(20)  NOT NULL DEFAULT '1st Sem',
  `academic_year` VARCHAR(20)  NOT NULL DEFAULT '2024-2025',
  `max_slots`     INT(11)      NOT NULL DEFAULT 40,
  PRIMARY KEY (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 2. Create section_schedules table (which schedules belong to a section)
CREATE TABLE IF NOT EXISTS `section_schedules` (
  `id`          INT(11) NOT NULL AUTO_INCREMENT,
  `section_id`  INT(11) NOT NULL,
  `schedule_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_section_schedule` (`section_id`, `schedule_id`),
  FOREIGN KEY (`section_id`)  REFERENCES `sections`  (`section_id`) ON DELETE CASCADE,
  FOREIGN KEY (`schedule_id`) REFERENCES `schedules` (`schedule_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 3. Add section_id and student_type to students table
ALTER TABLE `students`
  ADD COLUMN IF NOT EXISTS `section_id`   INT(11)     DEFAULT NULL AFTER `year_level`,
  ADD COLUMN IF NOT EXISTS `student_type` VARCHAR(20) DEFAULT 'REGULAR' AFTER `section_id`;

ALTER TABLE `students`
  ADD CONSTRAINT `fk_students_section`
  FOREIGN KEY (`section_id`) REFERENCES `sections` (`section_id`) ON DELETE SET NULL;

-- 4. Add semester/academic_year/max_slots to schedules (if not already added)
ALTER TABLE `schedules`
  ADD COLUMN IF NOT EXISTS `semester`      VARCHAR(20) DEFAULT '1st Sem'   AFTER `room`,
  ADD COLUMN IF NOT EXISTS `academic_year` VARCHAR(20) DEFAULT '2024-2025' AFTER `semester`,
  ADD COLUMN IF NOT EXISTS `max_slots`     INT(11)     DEFAULT 40          AFTER `academic_year`;

-- ============================================================
-- SAMPLE DATA (optional - delete if not needed)
-- ============================================================
INSERT IGNORE INTO `sections` (section_name, course, year_level, semester, academic_year, max_slots) VALUES
('BSIT 1-A', 'BSIT', '1ST YEAR', '1st Sem', '2024-2025', 40),
('BSIT 2-A', 'BSIT', '2ND YEAR', '1st Sem', '2024-2025', 40),
('BSCS 1-A', 'BSCS', '1ST YEAR', '1st Sem', '2024-2025', 40);
