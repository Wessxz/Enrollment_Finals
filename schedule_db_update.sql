-- ============================================================
-- SCHEDULE TABLE UPDATE - Add Real-Life Registrar Features
-- Run this to add semester and max_slots columns
-- ============================================================

-- Add semester column (1st Sem, 2nd Sem, Summer)
ALTER TABLE `schedules`
ADD COLUMN `semester` VARCHAR(20) DEFAULT '1st Sem' AFTER `room`;

-- Add max_slots column (default 40 students per class)
ALTER TABLE `schedules`
ADD COLUMN `max_slots` INT DEFAULT 40 AFTER `semester`;

-- Add academic_year column (e.g. 2024-2025)
ALTER TABLE `schedules`
ADD COLUMN `academic_year` VARCHAR(20) DEFAULT '2024-2025' AFTER `max_slots`;

-- ============================================================
-- VERIFICATION QUERY
-- ============================================================
-- Run this to check if columns were added successfully:
-- SELECT * FROM schedules LIMIT 1;
