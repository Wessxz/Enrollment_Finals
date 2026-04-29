-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2026 at 11:16 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `enrollment_system_db_1`
--

-- --------------------------------------------------------

--
-- Table structure for table `announcements`
--

CREATE TABLE `announcements` (
  `announcement_id` int(11) NOT NULL,
  `title` varchar(150) NOT NULL,
  `content` text NOT NULL,
  `posted_by` int(11) DEFAULT NULL,
  `date_posted` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `billing_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `tuition_fee` decimal(10,2) NOT NULL,
  `misc_fee` decimal(10,2) NOT NULL,
  `total_amount` decimal(10,2) NOT NULL,
  `balance` decimal(10,2) NOT NULL,
  `payment_mode` varchar(20) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`billing_id`, `student_id`, `tuition_fee`, `misc_fee`, `total_amount`, `balance`, `payment_mode`, `status`) VALUES
(4, 2205, 5400.00, 19200.00, 24600.00, 14100.00, 'Partial Payment', 'PARTIAL'),
(5, 2204, 10800.00, 19000.00, 29800.00, 23800.00, 'Partial Payment', 'PARTIAL'),
(6, 2202, 10800.00, 22700.00, 33500.00, 30500.00, 'Partial Payment', 'PARTIAL'),
(7, 2203, 10800.00, 42313.00, 53113.00, 53113.00, 'Full Payment', 'UNPAID'),
(8, 2206, 5400.00, 23000.00, 28400.00, 25400.00, 'Partial Payment', 'PARTIAL'),
(10, 2207, 10800.00, 10000.00, 20800.00, 0.00, 'Partial Payment', 'PAID');

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` int(11) NOT NULL,
  `course_code` varchar(20) NOT NULL,
  `course_name` varchar(150) NOT NULL,
  `department` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `course_code`, `course_name`, `department`) VALUES
(1, '2203', 'BSCS', 'CCS');

-- --------------------------------------------------------

--
-- Table structure for table `enrollments`
--

CREATE TABLE `enrollments` (
  `enrollment_id` int(11) NOT NULL,
  `student_id` varchar(20) NOT NULL,
  `course_id` int(11) NOT NULL,
  `semester` varchar(20) NOT NULL,
  `academic_year` varchar(20) NOT NULL,
  `status` enum('PENDING','APPROVED','DROPPED') DEFAULT 'PENDING',
  `date_enrolled` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollments`
--

INSERT INTO `enrollments` (`enrollment_id`, `student_id`, `course_id`, `semester`, `academic_year`, `status`, `date_enrolled`) VALUES
(2, '2207', 1, '1st Semester', '2025-2026', '', '2026-04-29 20:18:29');

-- --------------------------------------------------------

--
-- Table structure for table `enrollment_details`
--

CREATE TABLE `enrollment_details` (
  `detail_id` int(11) NOT NULL,
  `enrollment_id` int(11) NOT NULL,
  `schedule_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollment_details`
--

INSERT INTO `enrollment_details` (`detail_id`, `enrollment_id`, `schedule_id`) VALUES
(1, 2, 5),
(2, 2, 6),
(3, 2, 7),
(4, 2, 8),
(5, 2, 9),
(6, 2, 10),
(8, 2, 5),
(9, 2, 6),
(10, 2, 7),
(11, 2, 8),
(12, 2, 9),
(13, 2, 10);

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `faculty_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `department` varchar(100) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `grade_id` int(11) NOT NULL,
  `enrollment_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `term` enum('Prelim','Midterm','Final') NOT NULL,
  `grade_value` varchar(10) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `encoded_by` int(11) DEFAULT NULL,
  `date_encoded` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `grades_backup`
--

CREATE TABLE `grades_backup` (
  `grade_id` int(11) NOT NULL DEFAULT 0,
  `enrollment_detail_id` int(11) NOT NULL,
  `grade_value` varchar(10) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `encoded_by` int(11) DEFAULT NULL,
  `date_encoded` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_id` int(11) NOT NULL,
  `billing_id` int(11) NOT NULL,
  `or_number` varchar(50) NOT NULL,
  `amount_paid` decimal(10,2) NOT NULL,
  `payment_date` timestamp NOT NULL DEFAULT current_timestamp(),
  `cashier_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`payment_id`, `billing_id`, `or_number`, `amount_paid`, `payment_date`, `cashier_id`) VALUES
(1, 5, '000001', 6000.00, '2026-04-29 09:06:14', 15),
(7, 4, '000002', 3000.00, '2026-04-29 15:57:32', 15),
(8, 6, '000003', 3000.00, '2026-04-29 16:04:35', 15),
(9, 4, '000004', 4000.00, '2026-04-29 16:08:33', 15),
(10, 8, '000005', 3000.00, '2026-04-29 16:38:06', 15),
(11, 10, '000006', 3000.00, '2026-04-29 20:18:29', 14),
(12, 10, '000007', 5000.00, '2026-04-29 20:18:56', 14),
(13, 10, '000008', 1280000.00, '2026-04-29 20:19:20', 14);

-- --------------------------------------------------------

--
-- Table structure for table `schedules`
--

CREATE TABLE `schedules` (
  `schedule_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `faculty_id` int(11) DEFAULT NULL,
  `day_of_week` varchar(20) DEFAULT NULL,
  `start_time` time DEFAULT NULL,
  `end_time` time DEFAULT NULL,
  `room` varchar(50) DEFAULT NULL,
  `semester` varchar(20) DEFAULT NULL,
  `academic_year` varchar(20) DEFAULT NULL,
  `max_slots` int(11) DEFAULT 40
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`schedule_id`, `subject_id`, `faculty_id`, `day_of_week`, `start_time`, `end_time`, `room`, `semester`, `academic_year`, `max_slots`) VALUES
(5, 1, 6, 'Monday', '09:31:50', '09:31:50', '210', '1st Sem', '2026-2027', 40),
(6, 1, 6, 'Tuesday', '09:31:38', '10:31:38', '210', '1st Sem', '2026-2027', 40),
(7, 1, 6, 'Wednesday', '10:48:09', '10:48:09', '210', '1st Sem', '2026-2027', 40),
(8, 1, 6, 'Thursday', '11:07:02', '11:07:02', '210', '1st Sem', '2026-2027', 40),
(9, 1, 13, 'Friday', '11:14:27', '11:14:27', '210', '1st Sem', '2026-2027', 40),
(10, 1, 6, 'Monday', '09:00:00', '10:00:00', '210', '1st Sem', '2026-2027', 40);

-- --------------------------------------------------------

--
-- Table structure for table `sections`
--

CREATE TABLE `sections` (
  `section_id` int(11) NOT NULL,
  `section_name` varchar(50) DEFAULT NULL,
  `course` varchar(50) DEFAULT NULL,
  `year_level` int(11) DEFAULT NULL,
  `semester` varchar(20) DEFAULT NULL,
  `academic_year` varchar(20) DEFAULT NULL,
  `max_slots` int(11) NOT NULL DEFAULT 40
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sections`
--

INSERT INTO `sections` (`section_id`, `section_name`, `course`, `year_level`, `semester`, `academic_year`, `max_slots`) VALUES
(1, '32E1', 'BSIT', 1, '1st Sem', '2024-2025', 40),
(2, 'BSIT 1-A', 'BSIT', 1, '1st Sem', '2024-2025', 40),
(3, 'BSIT 2-A', 'BSIT', 2, '1st Sem', '2024-2025', 40),
(4, 'BSCS 1-A', 'BSCS', 1, '1st Sem', '2024-2025', 40),
(5, '32E2', 'BSIT', 2, '1st Sem', '2024-2025', 40);

-- --------------------------------------------------------

--
-- Table structure for table `section_schedules`
--

CREATE TABLE `section_schedules` (
  `id` int(11) NOT NULL,
  `section_id` int(11) NOT NULL,
  `schedule_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `section_schedules`
--

INSERT INTO `section_schedules` (`id`, `section_id`, `schedule_id`) VALUES
(6, 1, 5),
(7, 1, 6),
(8, 1, 7),
(11, 1, 8),
(9, 1, 9),
(10, 1, 10),
(13, 4, 5),
(14, 4, 7),
(12, 4, 9);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `student_id` varchar(20) DEFAULT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `course` varchar(100) DEFAULT NULL,
  `student_type` varchar(50) DEFAULT NULL,
  `year_level` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `status` enum('PENDING','VERIFIED') DEFAULT 'PENDING',
  `section_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `student_id`, `first_name`, `last_name`, `course`, `student_type`, `year_level`, `username`, `password`, `status`, `section_id`) VALUES
(2, '2202', 'sean', 'atog', 'BSIT', 'REGULAR', '1ST YEAR', 'sean', '$2y$10$sK3w9/3DFgDv54XVkhB50.GwNmwm5Iyeh.Oe7LGv0BacK9NyKvWRm', 'PENDING', 1),
(3, '2203', 'jason', 'bustrillo', 'BSIT', 'REGULAR', '1ST YEAR', 'jason', '$2y$10$jS9nVqWKHGAYO2xAOLsRCu5TVOf3.5NkfmcxAju5MuHWi2YFIMs3i', 'VERIFIED', 1),
(4, '2204', 'droga', 'Loop', 'BSIT', 'REGULAR', '1ST YEAR', 'Groga', '$2y$10$qPFnDkS9JxS4k/1LBD/k4epYNwFk0Uec4oJbi2InNz63YhCdzytV6', 'VERIFIED', 1),
(5, '2205', 'Ronnel John', 'Vasquez', 'BSIT', 'REGULAR', '1ST YEAR', 'rjtv11', '$2y$10$25Z8geGjfBZ/xfhmguQqbuhYGblVD5nizjmIT0gXopqVESeoZqsG.', 'VERIFIED', 4),
(6, NULL, 'Ronnel John', 'Vasquez', '', NULL, '', 'Akoto', '$2y$10$d7g5TrQdBrzcUTTV/SyxkOwV83UVPAaEmqKe8y53b7jJNCUyIqjA2', 'PENDING', NULL),
(7, '2206', 'Jason Guardian', 'Rymark', '2203', 'IRREGULAR', '1ST YEAR', 'account', '$2y$10$H/Yr18CJZf80oAdu1Ij4mue3rSV1s/YMkgpLzrCfQ0x9xO/3zPus.', 'PENDING', 4),
(8, NULL, 'lot', 'tol', '', NULL, '', 'tol', '$2y$10$BG1H7hf/ep6LEt17BS2Qz.hqsTopamJJcPevif5DuALut4hYdpWga', 'PENDING', NULL),
(9, '2207', 'ryamark1', 'guardian', '2203', 'REGULAR', '1ST YEAR', 'rymark1', '$2y$10$EH40RHbYuMzZLNKL2ntq4.dJ/lqk4iiBl7/Wx1VZOXiOc0LjhSAnO', 'VERIFIED', 1);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL,
  `course` varchar(100) DEFAULT NULL,
  `subject_code` varchar(20) NOT NULL,
  `subject_name` varchar(150) NOT NULL,
  `units` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`subject_id`, `course`, `subject_code`, `subject_name`, `units`) VALUES
(1, 'BSIT', '2202', 'IT Elective', 5),
(2, '2203', '2203', 'Programming', 5);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` enum('Admin','Registrar','Cashier','Faculty','Student') NOT NULL,
  `status` enum('PENDING','VERIFIED','INACTIVE') DEFAULT 'VERIFIED',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password_hash`, `role`, `status`, `created_at`) VALUES
(1, 'admin', 'admin123', 'Admin', 'VERIFIED', '2026-04-19 10:25:25'),
(2, 'Ison', '$2y$10$yclF9nsV2/VDV1c/5ozJFeuBe2Hdmb5DwMzxmYgmZzR3r0DHFcVnO', 'Student', 'VERIFIED', '2026-04-19 10:42:32'),
(3, 'Droga', '$2y$10$ctqa7OW9gooCLgXM.0rX7.59eJ6rfJrY9adB2wdcSmisvdxuTnp.u', 'Student', 'VERIFIED', '2026-04-19 11:36:59'),
(4, 'Registrar', 'registrar123', 'Registrar', 'VERIFIED', '2026-04-19 15:24:31'),
(5, 'Ronnel', '$2y$10$pjufKdxNUWVM.K893aGof.yBDX3wROztuLmlz8gOXjK/n3MrxlZni', 'Student', 'VERIFIED', '2026-04-22 07:25:24'),
(6, 'Faculty', '123', 'Faculty', 'VERIFIED', '2026-04-22 08:13:41'),
(7, 'jb', '$2y$10$KFvgsEYAjpQAxPbgMDp68OjMd2NtanOMEmMFIAvlkGkpWtB/hOv7W', 'Student', 'PENDING', '2026-04-22 15:45:56'),
(9, 'patrick', '$2y$10$JVxfoS1gz8AqbypBtNtacO2b8RuygAzOaZYFNw5vEBfb0pYyuOYe6', 'Student', 'PENDING', '2026-04-22 16:45:36'),
(10, 'lot', '$2y$10$yIKTo8LPzSsi3PI2Fi/dueAgycauBEqdmAKtQLoR.eZf.fzuDHG32', 'Student', 'PENDING', '2026-04-22 16:48:56'),
(11, 'ratan', '$2y$10$8Tsmj0bZsPv7uhYY9CiUnuzFx6vrHhL8bQludOWdZgkxTVWyehCbK', 'Student', 'PENDING', '2026-04-22 16:51:32'),
(12, 'raul', '$2y$10$0KOG8IOFfhl1.4UPQrCCau5VirXHFjL2Vfcd4m0wyji.s8hXOn.Ym', 'Student', 'VERIFIED', '2026-04-22 17:07:26'),
(13, 'allen', '123', 'Faculty', 'VERIFIED', '2026-04-25 03:13:24'),
(14, 'Cashier', '123', 'Cashier', 'VERIFIED', '2026-04-27 17:50:56'),
(15, 'Cashier1', 'cashier', 'Cashier', 'VERIFIED', '2026-04-27 17:54:54'),
(19, 'cashier123', 'cashier', 'Cashier', 'PENDING', '2026-04-29 08:40:56');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `announcements`
--
ALTER TABLE `announcements`
  ADD PRIMARY KEY (`announcement_id`),
  ADD KEY `posted_by` (`posted_by`);

--
-- Indexes for table `billing`
--
ALTER TABLE `billing`
  ADD PRIMARY KEY (`billing_id`),
  ADD UNIQUE KEY `enrollment_id` (`student_id`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`course_id`),
  ADD UNIQUE KEY `course_code` (`course_code`);

--
-- Indexes for table `enrollments`
--
ALTER TABLE `enrollments`
  ADD PRIMARY KEY (`enrollment_id`),
  ADD KEY `course_id` (`course_id`),
  ADD KEY `fk_enrollments_student` (`student_id`);

--
-- Indexes for table `enrollment_details`
--
ALTER TABLE `enrollment_details`
  ADD PRIMARY KEY (`detail_id`),
  ADD KEY `enrollment_id` (`enrollment_id`),
  ADD KEY `schedule_id` (`schedule_id`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`faculty_id`),
  ADD KEY `fk_faculty_user` (`user_id`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`grade_id`),
  ADD KEY `enrollment_id` (`enrollment_id`),
  ADD KEY `subject_id` (`subject_id`),
  ADD KEY `encoded_by` (`encoded_by`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`payment_id`),
  ADD UNIQUE KEY `or_number` (`or_number`),
  ADD KEY `billing_id` (`billing_id`),
  ADD KEY `cashier_id` (`cashier_id`);

--
-- Indexes for table `schedules`
--
ALTER TABLE `schedules`
  ADD PRIMARY KEY (`schedule_id`),
  ADD KEY `subject_id` (`subject_id`),
  ADD KEY `faculty_id` (`faculty_id`);

--
-- Indexes for table `sections`
--
ALTER TABLE `sections`
  ADD PRIMARY KEY (`section_id`);

--
-- Indexes for table `section_schedules`
--
ALTER TABLE `section_schedules`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_section_schedule` (`section_id`,`schedule_id`),
  ADD KEY `schedule_id` (`schedule_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `student_id` (`student_id`),
  ADD KEY `fk_students_section` (`section_id`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`),
  ADD UNIQUE KEY `subject_code` (`subject_code`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `announcements`
--
ALTER TABLE `announcements`
  MODIFY `announcement_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `billing`
--
ALTER TABLE `billing`
  MODIFY `billing_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `enrollments`
--
ALTER TABLE `enrollments`
  MODIFY `enrollment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `enrollment_details`
--
ALTER TABLE `enrollment_details`
  MODIFY `detail_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `faculty_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `grades`
--
ALTER TABLE `grades`
  MODIFY `grade_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `schedules`
--
ALTER TABLE `schedules`
  MODIFY `schedule_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `sections`
--
ALTER TABLE `sections`
  MODIFY `section_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `section_schedules`
--
ALTER TABLE `section_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `announcements`
--
ALTER TABLE `announcements`
  ADD CONSTRAINT `announcements_ibfk_1` FOREIGN KEY (`posted_by`) REFERENCES `users` (`id`) ON DELETE SET NULL;

--
-- Constraints for table `enrollments`
--
ALTER TABLE `enrollments`
  ADD CONSTRAINT `enrollments_ibfk_2` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_id`),
  ADD CONSTRAINT `fk_enrollments_student` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`);

--
-- Constraints for table `enrollment_details`
--
ALTER TABLE `enrollment_details`
  ADD CONSTRAINT `enrollment_details_ibfk_1` FOREIGN KEY (`enrollment_id`) REFERENCES `enrollments` (`enrollment_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `enrollment_details_ibfk_2` FOREIGN KEY (`schedule_id`) REFERENCES `schedules` (`schedule_id`);

--
-- Constraints for table `faculty`
--
ALTER TABLE `faculty`
  ADD CONSTRAINT `fk_faculty_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `grades`
--
ALTER TABLE `grades`
  ADD CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`enrollment_id`) REFERENCES `enrollments` (`enrollment_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`),
  ADD CONSTRAINT `grades_ibfk_3` FOREIGN KEY (`encoded_by`) REFERENCES `users` (`id`) ON DELETE SET NULL;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`billing_id`) REFERENCES `billing` (`billing_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `payments_ibfk_2` FOREIGN KEY (`cashier_id`) REFERENCES `users` (`id`) ON DELETE SET NULL;

--
-- Constraints for table `schedules`
--
ALTER TABLE `schedules`
  ADD CONSTRAINT `schedules_ibfk_1` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`),
  ADD CONSTRAINT `schedules_ibfk_2` FOREIGN KEY (`faculty_id`) REFERENCES `users` (`id`) ON DELETE SET NULL;

--
-- Constraints for table `section_schedules`
--
ALTER TABLE `section_schedules`
  ADD CONSTRAINT `section_schedules_ibfk_1` FOREIGN KEY (`section_id`) REFERENCES `sections` (`section_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `section_schedules_ibfk_2` FOREIGN KEY (`schedule_id`) REFERENCES `schedules` (`schedule_id`) ON DELETE CASCADE;

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `fk_students_section` FOREIGN KEY (`section_id`) REFERENCES `sections` (`section_id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
