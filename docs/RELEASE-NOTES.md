# Release Notes

## 3.0.0 - ?

Breaking changes:
- Renamed method `TimeSpanExtensions.ToApproxFormat` to `ToApproxDescription`.

New features:
- Added method `DateTimeIsExtensions.IsUtc`.
- Added method `DateTimeToDateTimeOffsetExtensions.ToDateTimeOffset`.

Bug fixes / internal changes:
- (None)

## 2.3.0 - 30 November 2022

Breaking changes:
- (None)

New features:
- Added constructor overload to `Year`.
- Added method `DateTimeProvider.NowByTimeZoneId`.

Bug fixes / internal changes:
- (None)

## 2.2.0 - 17 August 2021

Breaking changes:
- (None)

New features:
- Added method `DateTimeWithExtensions.WithDate`.
- Added method `DateTimeWithExtensions.WithTime`.

Bug fixes / internal changes:
- (None)

## 2.1.0 - 17 March 2021

Breaking changes:
- (None)

New features:
- Added `Year` class.

Bug fixes / internal changes:
- (None)

## 2.0.0 - 15 July 2020

Breaking changes:
- `TimeMax` class now in correct namespace (`ByteDev.Time`).

New features:
- Added method `MonthExtensions.Length`.

Bug fixes / internal changes:
- (None)

## 1.3.0 - 15 July 2020

Breaking changes:
- (None)

New features:
- Added method `DateTimeExtensions.EndOfDay`.
- Added method `DateTimeExtensions.EndOfMonth`.
- Added method `DateTimeExtensions.EndOfYear`.
- Added method `DateTimeExtensions.EqualsDate`.
- Added method `DateTimeExtensions.EqualsTime`.
- Added method `DateTimeExtensions.WithHour`.
- Added method `DateTimeExtensions.WithMinute`.
- Added method `DateTimeExtensions.WithSecond`.
- Added method `DateTimeExtensions.WithMillisecond`.
- Added class `TimeMax`.

Bug fixes / internal changes:
- Updated nuspec details.

## 1.2.0 - 17 April 2020

Breaking changes:
- (None)

New features:
- Added `DateTimeRange` class.
- Added `DateRange` class.
- Added `DateTimeSubtractExtensions` class.
- Added `DateTimeTruncateExtensions.TruncateToDay` method.

Bug fixes:
- Fixed public comments for `IsBetween` method.

## 1.0.0 - 17 April 2020

Initial version.