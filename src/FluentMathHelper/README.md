# Fluent Math Helper
 A library with fluent math helper functions

## Instructions

	1. Calculate percentage of x:
		```decimal x = new Percentage().Amount(percentage).Of(x);```

	2. Calculate percentage increase from x to y
		```decimal x = new PercentageIncrease().From(x).To(y);```

	3. Calculate percentage decrease from x to y
		```decimal x = new PercentageDecrease().From(x).To(y);```

	4. Calculate how much percent of x is y
		```decimal x = new PercentageOf().Whole(whole).Is(value);```
