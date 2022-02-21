# Adding dependencies health monitorization on a AZ Function

## Result JSON

```JSON
{
	"HealthStatus": 2,
	"Duration": {
		"Ticks": 4385808,
		"Days": 0,
		"Hours": 0,
		"Milliseconds": 438,
		"Minutes": 0,
		"Seconds": 0,
		"TotalDays": 0.000005076166666666666,
		"TotalHours": 0.000121828,
		"TotalMilliseconds": 438.5808,
		"TotalMinutes": 0.00730968,
		"TotalSeconds": 0.4385808
	},
	"Entries": {
		"IdentityService-check": {
			"Data": {},
			"Description": null,
			"Duration": {
				"Ticks": 4226759,
				"Days": 0,
				"Hours": 0,
				"Milliseconds": 422,
				"Minutes": 0,
				"Seconds": 0,
				"TotalDays": 0.000004892082175925926,
				"TotalHours": 0.00011740997222222222,
				"TotalMilliseconds": 422.6759,
				"TotalMinutes": 0.007044598333333333,
				"TotalSeconds": 0.4226759
			},
			"Exception": null,
			"Status": 2,
			"Tags": []
		},
		"DependencyService-check": {
			"Data": {},
			"Description": null,
			"Duration": {
				"Ticks": 3639225,
				"Days": 0,
				"Hours": 0,
				"Milliseconds": 363,
				"Minutes": 0,
				"Seconds": 0,
				"TotalDays": 0.000004212065972222222,
				"TotalHours": 0.00010108958333333333,
				"TotalMilliseconds": 363.9225,
				"TotalMinutes": 0.006065375,
				"TotalSeconds": 0.3639225
			},
			"Exception": null,
			"Status": 2,
			"Tags": []
		},
		"SignalRService-check": {
			"Data": {},
			"Description": null,
			"Duration": {
				"Ticks": 4121570,
				"Days": 0,
				"Hours": 0,
				"Milliseconds": 412,
				"Minutes": 0,
				"Seconds": 0,
				"TotalDays": 0.000004770335648148148,
				"TotalHours": 0.00011448805555555555,
				"TotalMilliseconds": 412.157,
				"TotalMinutes": 0.0068692833333333339,
				"TotalSeconds": 0.412157
			},
			"Exception": null,
			"Status": 2,
			"Tags": []
		}
	}
}
```