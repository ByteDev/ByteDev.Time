[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.Time.svg)](https://www.nuget.org/packages/ByteDev.Time)
[![Build status](https://ci.appveyor.com/api/projects/status/github/ByteDev/ByteDev.Time?branch=master&svg=true)](https://ci.appveyor.com/project/ByteDev/ByteDev.Time/branch/master)
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

## Usage

The package has the following types and extension methods:

Types:
- DateTimeProvider (IDateTimeProvider)
- DateTimeOffsetProvider (IDateTimeOffsetProvider)
- DateTimeRange
- DateRange
- Month
- TimeMax
- Year

Extension methods:
- DateTime
  - AddWeeks
  - EndOfDay
  - EndOfMonth
  - EndOfYear
  - EqualsDate
  - EqualsTime
  - GetDayAsOrdinal
  - SubtractYears
  - SubtractMonths
  - SubtractWeeks
  - SubtractDays
  - SubtractHours
  - SubtractMinutes
  - SubtractSeconds
  - SubtractMilliseconds
  - MonthLength
  - WithYear
  - WithMonth
  - WithDay
  - WithHour
  - WithMinute
  - WithSecond
  - WithMillisecond
  - IsLastDayOfTheMonth
  - IsWeekend
  - IsLeapYear
  - IsAfter
  - IsBefore
  - IsBetween
  - IsMonth
  - ToStringDateDayShort
  - ToStringDateDayLong
  - ToStringDayOnly
  - ToStringSortable
  - TruncateToDay
  - TruncateToHour
  - TruncateToMinute  
  - TruncateToSecond   
- DayOfWeek
  - ToStringShort
- Month
  - ToStringShort
  - Length
- TimeSpan
  - ToApproxFormat