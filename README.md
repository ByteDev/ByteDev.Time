[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.Time.svg)](https://www.nuget.org/packages/ByteDev.Time)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/ByteDev/ByteDev.Template.LibraryPackage/blob/master/LICENSE)

# ByteDev.Time

.NET standard library of time related types and extension methods.

## Installation

ByteDev.Time has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.Time is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.Time`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.Time/).

## Release Notes

Releases follow semantic versioning.

Full details of the release notes can be viewed on [GitHub](https://github.com/ByteDev/ByteDev.Time/blob/master/docs/RELEASE-NOTES.md).

## Code

The repo can be cloned from git bash:

`git clone https://github.com/ByteDev/ByteDev.Time`

## Usage

The package has the following types and extension methods:

Types:
- DateTimeProvider (IDateTimeProvider)
- DateTimeOffsetProvider (IDateTimeOffsetProvider)
- Month

Extension methods:
- DateTime
  - GetDayAsOrdinal
  - AddWeeks
  - SubtractWeeks
  - DaysInMonth
  - WithYear
  - WithMonth
  - WithDay
  - IsLastDayOfTheMonth
  - IsWeekend
  - IsLeapYear
  - IsAfter
  - IsBefore
  - IsBetween
  - ToStringDateDayShort
  - ToStringDateDayLong
  - ToStringDayOnly
  - ToStringSortable
  - TruncateToSecond
  - TruncateToMinute
  - TruncateToHour
- DayOfWeek
  - ToStringShort
- Month
  - ToStringShort
- TimeSpan
  - ToApproxFormat