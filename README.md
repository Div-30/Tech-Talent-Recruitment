# Tech Talent Recruitment — Job Application Management System

A web-based job application management system built for **Tech Innovators** HR department. It provides a streamlined experience for applicants to submit and track their applications, and for HR staff to review and manage those applications.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
  - [Applicant Interface](#applicant-interface)
  - [HR Management Interface](#hr-management-interface)
- [Business Rules](#business-rules)
- [Available Job Positions](#available-job-positions)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

---

## Project Overview

The HR department of **Tech Innovators** has opened applications for various positions within the company. This system allows candidates to submit job applications online and enables HR personnel to efficiently review, approve, or reject those applications — all through dedicated, role-based interfaces.

---

## Features

### Applicant Interface

| # | Feature |
|---|---------|
| 1 | **Submit an application** — provide email, full name, date of birth, field of expertise, years of experience, desired job position, and a personal statement explaining why you are a good fit for the role. |
| 2 | **Track application status** — view the current status of your own application (`Approved`, `Under Review`, or `Rejected`). Each applicant can only see their own data. |
| 3 | **Withdraw an application** — cancel and remove a submitted application at any time. |
| 4 | **Update an application** — change the target position or update any personal details after submission. |

### HR Management Interface

| # | Feature |
|---|---------|
| 1 | **View all applications** — browse the list of submitted applications, filterable by job position. |
| 2 | **Change application status** — mark any application as `Approved`, `Under Review`, or `Rejected`. |

---

## Business Rules

> The following eligibility constraints are enforced automatically by the system:

- ✅ **Minimum experience:** Applicants must have **at least 2 years** of experience in their relevant field to apply.
- ✅ **Age limit:** Applicants must be **under 35 years old** at the time of submission.

Applications that do not meet these criteria will be rejected at the validation stage.

---

## Available Job Positions

The following positions are pre-loaded in the database and available for selection during the application process:

| Position |
|----------|
| Backend Developer |
| Frontend Developer |
| Software Tester |
| DevOps Engineer |
| Network Engineer |

---

## Database Schema

### `JOB_POSITIONS`

Stores the available job positions (seeded manually into the database).

| Column | Type | Description |
|--------|------|-------------|
| `id` | Integer (PK) | Unique identifier |
| `title` | String | Position name (e.g., *Backend Developer*) |

### `CANDIDATES`

Stores applicant data; each candidate is linked to a job position.

| Column | Type | Description |
|--------|------|-------------|
| `id` | Integer (PK) | Unique identifier |
| `email` | String | Applicant's email address |
| `full_name` | String | Applicant's full name |
| `date_of_birth` | Date | Used to verify age eligibility |
| `field_of_expertise` | String | Applicant's area of expertise |
| `years_of_experience` | Integer | Must be ≥ 2 |
| `personal_statement` | Text | Why the applicant is a good fit |
| `status` | Enum | `approved` / `under_review` / `rejected` |
| `job_position_id` | Integer (FK) | References `JOB_POSITIONS.id` |

**Relationship:** `CANDIDATES` → `JOB_POSITIONS` is a **many-to-one** relationship (many candidates can apply for the same position).

---

## Getting Started

### Prerequisites

- Node.js / Python / Java *(depending on the technology stack used)*
- A relational database (e.g., PostgreSQL, MySQL, or SQLite)
- Git

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/Div-30/Tech-Talent-Recruitment.git
cd Tech-Talent-Recruitment

# 2. Install dependencies
npm install        # or: pip install -r requirements.txt

# 3. Set up environment variables
cp .env.example .env
# Edit .env with your database credentials and settings

# 4. Run database migrations & seed job positions
npm run migrate    # or the equivalent command for your stack
npm run seed

# 5. Start the development server
npm run dev
```

---

## Usage

### As an Applicant

1. Navigate to the applicant portal.
2. Fill in the application form with your personal details, field of expertise, years of experience, and select the position you want to apply for.
3. Add a brief personal statement explaining why you are a great fit.
4. Submit the form — you will only be allowed to proceed if you meet the eligibility criteria (age < 35 and experience ≥ 2 years).
5. Log in to check your application status at any time, update your details, or withdraw your application.

### As an HR Manager

1. Log in to the HR management portal.
2. Browse the full list of submitted applications, filtered by position if needed.
3. Open an application and change its status to `Approved`, `Under Review`, or `Rejected`.

---

## Contributing

1. Fork the repository.
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Commit your changes: `git commit -m "feat: add your feature"`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Open a Pull Request.

---

## License

This project is licensed under the [MIT License](LICENSE).
