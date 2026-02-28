# Tech Talent Recruitment

A job application management system built for **Tech Innovators HR Department** to streamline hiring across multiple technical roles. The system provides a dedicated interface for applicants to submit and manage their applications, and a separate interface for HR staff to review and update application statuses.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
  - [Applicant Interface](#applicant-interface)
  - [HR Management Interface](#hr-management-interface)
- [Eligibility Requirements](#eligibility-requirements)
- [Available Job Positions](#available-job-positions)
- [Database Schema](#database-schema)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

Tech Innovators has opened job applications for multiple technical positions. This system manages the full lifecycle of a job application — from submission through review to final decision — while ensuring each applicant can only view and manage their own data.

---

## Features

### Applicant Interface

- **Submit an Application** — Applicants fill in the following details:
  - Full name
  - Email address
  - Date of birth
  - Field of expertise
  - Years of experience
  - Desired job position (selected from available openings)
  - Brief personal statement explaining why they are a good fit for the role
- **Track Application Status** — Applicants can check whether their application is:
  - `Under Review`
  - `Approved`
  - `Rejected`
  > **Privacy:** Applicants can only view their own application data.
- **Withdraw Application** — Applicants can retract their submitted application at any time.
- **Update Application** — Applicants can edit their application to change the target position or update any personal details.

### HR Management Interface

- **View Applications** — Browse all submitted applications, filterable by job position.
- **Update Application Status** — HR staff can set the status of any application to:
  - `Approved`
  - `Under Review`
  - `Rejected`

---

## Eligibility Requirements

Applications that do not meet the following criteria will not be accepted:

| Requirement | Rule |
|---|---|
| Minimum experience | At least **2 years** in the relevant field |
| Maximum age | Under **35 years old** at the time of application |

---

## Available Job Positions

The following positions are pre-loaded in the database:

- Backend Developer
- Frontend Developer
- Software Tester
- DevOps Engineer
- Network Engineer

---

## Database Schema

### `JOB_POSITIONS`

| Column | Type | Description |
|---|---|---|
| `id` | Integer (PK) | Auto-incremented primary key |
| `title` | String | Name of the job position |

> Values are seeded manually: Backend Developer, Frontend Developer, Software Tester, DevOps Engineer, Network Engineer.

### `CANDIDATES`

| Column | Type | Description |
|---|---|---|
| `id` | Integer (PK) | Auto-incremented primary key |
| `full_name` | String | Applicant's full name |
| `email` | String (unique) | Applicant's email address |
| `date_of_birth` | Date | Used to verify age eligibility |
| `field_of_expertise` | String | Applicant's area of specialization |
| `years_of_experience` | Integer | Must be ≥ 2 |
| `job_position_id` | Integer (FK → JOB_POSITIONS) | The position being applied for |
| `personal_statement` | Text | Why the applicant is a good fit |
| `status` | Enum | `under_review` \| `approved` \| `rejected` (default: `under_review`) |
| `created_at` | Timestamp | Submission timestamp |
| `updated_at` | Timestamp | Last update timestamp |

**Relationship:** Each `CANDIDATE` record belongs to one `JOB_POSITION`; one `JOB_POSITION` can have many `CANDIDATE` applications.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Backend | C# / ASP.NET Core |
| Database | SQL Server / SQLite |
| Frontend | Razor Pages / HTML, CSS, JavaScript |
| Authentication | Session-based or JWT |

---

## Getting Started

### Prerequisites

- .NET SDK 8.0+
- A running database instance (SQL Server or SQLite for development)

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/Div-30/Tech-Talent-Recruitment.git
cd Tech-Talent-Recruitment

# 2. Restore dependencies
dotnet restore

# 3. Apply database migrations
dotnet ef database update

# 4. Start the development server
dotnet run
```

Open your browser at `http://localhost:5000` (or `https://localhost:5001` for HTTPS).

---

## Usage

### Applicant Flow

1. Navigate to the **Apply** page.
2. Complete all required fields and submit the form.
3. Log in to the **Applicant Dashboard** to track your application status, update details, or withdraw your application.

### HR Flow

1. Log in to the **HR Dashboard** using HR credentials.
2. Browse applications by job position.
3. Click on an application to view full details and update its status.

---

## Contributing

1. Fork the repository.
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Commit your changes: `git commit -m "Add your message here"`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Open a Pull Request.

---

## License

This project is licensed under the [MIT License](LICENSE).
