# Adding dependencies health monitorization on a AZ Function

## Result JSON

```JSON
{
	"HealthStatus": 2,
	"Duration": {
		"Ticks": 4653858,
		"Days": 0,
		"Hours": 0,
		"Milliseconds": 465,
		"Minutes": 0,
		"Seconds": 0,
		"TotalDays": 0.000005386409722222223,
		"TotalHours": 0.00012927383333333334,
		"TotalMilliseconds": 465.3858,
		"TotalMinutes": 0.00775643,
		"TotalSeconds": 0.4653858
	},
	"Entries": {
		"DependencyService-check": {
			"Data": {},
			"Description": null,
			"Duration": {
				"Ticks": 3322456,
				"Days": 0,
				"Hours": 0,
				"Milliseconds": 332,
				"Minutes": 0,
				"Seconds": 0,
				"TotalDays": 0.000003845435185185185,
				"TotalHours": 0.00009229044444444445,
				"TotalMilliseconds": 332.2456,
				"TotalMinutes": 0.005537426666666667,
				"TotalSeconds": 0.3322456
			},
			"Exception": null,
			"Status": 2,
			"Tags": []
		},
		"IdentityService-check": {
			"Data": {},
			"Description": null,
			"Duration": {
				"Ticks": 4535380,
				"Days": 0,
				"Hours": 0,
				"Milliseconds": 453,
				"Minutes": 0,
				"Seconds": 0,
				"TotalDays": 0.000005249282407407408,
				"TotalHours": 0.00012598277777777777,
				"TotalMilliseconds": 453.538,
				"TotalMinutes": 0.007558966666666667,
				"TotalSeconds": 0.453538
			},
			"Exception": null,
			"Status": 2,
			"Tags": []
		}
	}
}
```