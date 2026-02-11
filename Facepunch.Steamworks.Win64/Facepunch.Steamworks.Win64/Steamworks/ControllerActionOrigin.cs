using System;

namespace Steamworks
{
	// Token: 0x02000079 RID: 121
	public enum ControllerActionOrigin
	{
		// Token: 0x04000CAD RID: 3245
		None,
		// Token: 0x04000CAE RID: 3246
		A,
		// Token: 0x04000CAF RID: 3247
		B,
		// Token: 0x04000CB0 RID: 3248
		X,
		// Token: 0x04000CB1 RID: 3249
		Y,
		// Token: 0x04000CB2 RID: 3250
		LeftBumper,
		// Token: 0x04000CB3 RID: 3251
		RightBumper,
		// Token: 0x04000CB4 RID: 3252
		LeftGrip,
		// Token: 0x04000CB5 RID: 3253
		RightGrip,
		// Token: 0x04000CB6 RID: 3254
		Start,
		// Token: 0x04000CB7 RID: 3255
		Back,
		// Token: 0x04000CB8 RID: 3256
		LeftPad_Touch,
		// Token: 0x04000CB9 RID: 3257
		LeftPad_Swipe,
		// Token: 0x04000CBA RID: 3258
		LeftPad_Click,
		// Token: 0x04000CBB RID: 3259
		LeftPad_DPadNorth,
		// Token: 0x04000CBC RID: 3260
		LeftPad_DPadSouth,
		// Token: 0x04000CBD RID: 3261
		LeftPad_DPadWest,
		// Token: 0x04000CBE RID: 3262
		LeftPad_DPadEast,
		// Token: 0x04000CBF RID: 3263
		RightPad_Touch,
		// Token: 0x04000CC0 RID: 3264
		RightPad_Swipe,
		// Token: 0x04000CC1 RID: 3265
		RightPad_Click,
		// Token: 0x04000CC2 RID: 3266
		RightPad_DPadNorth,
		// Token: 0x04000CC3 RID: 3267
		RightPad_DPadSouth,
		// Token: 0x04000CC4 RID: 3268
		RightPad_DPadWest,
		// Token: 0x04000CC5 RID: 3269
		RightPad_DPadEast,
		// Token: 0x04000CC6 RID: 3270
		LeftTrigger_Pull,
		// Token: 0x04000CC7 RID: 3271
		LeftTrigger_Click,
		// Token: 0x04000CC8 RID: 3272
		RightTrigger_Pull,
		// Token: 0x04000CC9 RID: 3273
		RightTrigger_Click,
		// Token: 0x04000CCA RID: 3274
		LeftStick_Move,
		// Token: 0x04000CCB RID: 3275
		LeftStick_Click,
		// Token: 0x04000CCC RID: 3276
		LeftStick_DPadNorth,
		// Token: 0x04000CCD RID: 3277
		LeftStick_DPadSouth,
		// Token: 0x04000CCE RID: 3278
		LeftStick_DPadWest,
		// Token: 0x04000CCF RID: 3279
		LeftStick_DPadEast,
		// Token: 0x04000CD0 RID: 3280
		Gyro_Move,
		// Token: 0x04000CD1 RID: 3281
		Gyro_Pitch,
		// Token: 0x04000CD2 RID: 3282
		Gyro_Yaw,
		// Token: 0x04000CD3 RID: 3283
		Gyro_Roll,
		// Token: 0x04000CD4 RID: 3284
		PS4_X,
		// Token: 0x04000CD5 RID: 3285
		PS4_Circle,
		// Token: 0x04000CD6 RID: 3286
		PS4_Triangle,
		// Token: 0x04000CD7 RID: 3287
		PS4_Square,
		// Token: 0x04000CD8 RID: 3288
		PS4_LeftBumper,
		// Token: 0x04000CD9 RID: 3289
		PS4_RightBumper,
		// Token: 0x04000CDA RID: 3290
		PS4_Options,
		// Token: 0x04000CDB RID: 3291
		PS4_Share,
		// Token: 0x04000CDC RID: 3292
		PS4_LeftPad_Touch,
		// Token: 0x04000CDD RID: 3293
		PS4_LeftPad_Swipe,
		// Token: 0x04000CDE RID: 3294
		PS4_LeftPad_Click,
		// Token: 0x04000CDF RID: 3295
		PS4_LeftPad_DPadNorth,
		// Token: 0x04000CE0 RID: 3296
		PS4_LeftPad_DPadSouth,
		// Token: 0x04000CE1 RID: 3297
		PS4_LeftPad_DPadWest,
		// Token: 0x04000CE2 RID: 3298
		PS4_LeftPad_DPadEast,
		// Token: 0x04000CE3 RID: 3299
		PS4_RightPad_Touch,
		// Token: 0x04000CE4 RID: 3300
		PS4_RightPad_Swipe,
		// Token: 0x04000CE5 RID: 3301
		PS4_RightPad_Click,
		// Token: 0x04000CE6 RID: 3302
		PS4_RightPad_DPadNorth,
		// Token: 0x04000CE7 RID: 3303
		PS4_RightPad_DPadSouth,
		// Token: 0x04000CE8 RID: 3304
		PS4_RightPad_DPadWest,
		// Token: 0x04000CE9 RID: 3305
		PS4_RightPad_DPadEast,
		// Token: 0x04000CEA RID: 3306
		PS4_CenterPad_Touch,
		// Token: 0x04000CEB RID: 3307
		PS4_CenterPad_Swipe,
		// Token: 0x04000CEC RID: 3308
		PS4_CenterPad_Click,
		// Token: 0x04000CED RID: 3309
		PS4_CenterPad_DPadNorth,
		// Token: 0x04000CEE RID: 3310
		PS4_CenterPad_DPadSouth,
		// Token: 0x04000CEF RID: 3311
		PS4_CenterPad_DPadWest,
		// Token: 0x04000CF0 RID: 3312
		PS4_CenterPad_DPadEast,
		// Token: 0x04000CF1 RID: 3313
		PS4_LeftTrigger_Pull,
		// Token: 0x04000CF2 RID: 3314
		PS4_LeftTrigger_Click,
		// Token: 0x04000CF3 RID: 3315
		PS4_RightTrigger_Pull,
		// Token: 0x04000CF4 RID: 3316
		PS4_RightTrigger_Click,
		// Token: 0x04000CF5 RID: 3317
		PS4_LeftStick_Move,
		// Token: 0x04000CF6 RID: 3318
		PS4_LeftStick_Click,
		// Token: 0x04000CF7 RID: 3319
		PS4_LeftStick_DPadNorth,
		// Token: 0x04000CF8 RID: 3320
		PS4_LeftStick_DPadSouth,
		// Token: 0x04000CF9 RID: 3321
		PS4_LeftStick_DPadWest,
		// Token: 0x04000CFA RID: 3322
		PS4_LeftStick_DPadEast,
		// Token: 0x04000CFB RID: 3323
		PS4_RightStick_Move,
		// Token: 0x04000CFC RID: 3324
		PS4_RightStick_Click,
		// Token: 0x04000CFD RID: 3325
		PS4_RightStick_DPadNorth,
		// Token: 0x04000CFE RID: 3326
		PS4_RightStick_DPadSouth,
		// Token: 0x04000CFF RID: 3327
		PS4_RightStick_DPadWest,
		// Token: 0x04000D00 RID: 3328
		PS4_RightStick_DPadEast,
		// Token: 0x04000D01 RID: 3329
		PS4_DPad_North,
		// Token: 0x04000D02 RID: 3330
		PS4_DPad_South,
		// Token: 0x04000D03 RID: 3331
		PS4_DPad_West,
		// Token: 0x04000D04 RID: 3332
		PS4_DPad_East,
		// Token: 0x04000D05 RID: 3333
		PS4_Gyro_Move,
		// Token: 0x04000D06 RID: 3334
		PS4_Gyro_Pitch,
		// Token: 0x04000D07 RID: 3335
		PS4_Gyro_Yaw,
		// Token: 0x04000D08 RID: 3336
		PS4_Gyro_Roll,
		// Token: 0x04000D09 RID: 3337
		XBoxOne_A,
		// Token: 0x04000D0A RID: 3338
		XBoxOne_B,
		// Token: 0x04000D0B RID: 3339
		XBoxOne_X,
		// Token: 0x04000D0C RID: 3340
		XBoxOne_Y,
		// Token: 0x04000D0D RID: 3341
		XBoxOne_LeftBumper,
		// Token: 0x04000D0E RID: 3342
		XBoxOne_RightBumper,
		// Token: 0x04000D0F RID: 3343
		XBoxOne_Menu,
		// Token: 0x04000D10 RID: 3344
		XBoxOne_View,
		// Token: 0x04000D11 RID: 3345
		XBoxOne_LeftTrigger_Pull,
		// Token: 0x04000D12 RID: 3346
		XBoxOne_LeftTrigger_Click,
		// Token: 0x04000D13 RID: 3347
		XBoxOne_RightTrigger_Pull,
		// Token: 0x04000D14 RID: 3348
		XBoxOne_RightTrigger_Click,
		// Token: 0x04000D15 RID: 3349
		XBoxOne_LeftStick_Move,
		// Token: 0x04000D16 RID: 3350
		XBoxOne_LeftStick_Click,
		// Token: 0x04000D17 RID: 3351
		XBoxOne_LeftStick_DPadNorth,
		// Token: 0x04000D18 RID: 3352
		XBoxOne_LeftStick_DPadSouth,
		// Token: 0x04000D19 RID: 3353
		XBoxOne_LeftStick_DPadWest,
		// Token: 0x04000D1A RID: 3354
		XBoxOne_LeftStick_DPadEast,
		// Token: 0x04000D1B RID: 3355
		XBoxOne_RightStick_Move,
		// Token: 0x04000D1C RID: 3356
		XBoxOne_RightStick_Click,
		// Token: 0x04000D1D RID: 3357
		XBoxOne_RightStick_DPadNorth,
		// Token: 0x04000D1E RID: 3358
		XBoxOne_RightStick_DPadSouth,
		// Token: 0x04000D1F RID: 3359
		XBoxOne_RightStick_DPadWest,
		// Token: 0x04000D20 RID: 3360
		XBoxOne_RightStick_DPadEast,
		// Token: 0x04000D21 RID: 3361
		XBoxOne_DPad_North,
		// Token: 0x04000D22 RID: 3362
		XBoxOne_DPad_South,
		// Token: 0x04000D23 RID: 3363
		XBoxOne_DPad_West,
		// Token: 0x04000D24 RID: 3364
		XBoxOne_DPad_East,
		// Token: 0x04000D25 RID: 3365
		XBox360_A,
		// Token: 0x04000D26 RID: 3366
		XBox360_B,
		// Token: 0x04000D27 RID: 3367
		XBox360_X,
		// Token: 0x04000D28 RID: 3368
		XBox360_Y,
		// Token: 0x04000D29 RID: 3369
		XBox360_LeftBumper,
		// Token: 0x04000D2A RID: 3370
		XBox360_RightBumper,
		// Token: 0x04000D2B RID: 3371
		XBox360_Start,
		// Token: 0x04000D2C RID: 3372
		XBox360_Back,
		// Token: 0x04000D2D RID: 3373
		XBox360_LeftTrigger_Pull,
		// Token: 0x04000D2E RID: 3374
		XBox360_LeftTrigger_Click,
		// Token: 0x04000D2F RID: 3375
		XBox360_RightTrigger_Pull,
		// Token: 0x04000D30 RID: 3376
		XBox360_RightTrigger_Click,
		// Token: 0x04000D31 RID: 3377
		XBox360_LeftStick_Move,
		// Token: 0x04000D32 RID: 3378
		XBox360_LeftStick_Click,
		// Token: 0x04000D33 RID: 3379
		XBox360_LeftStick_DPadNorth,
		// Token: 0x04000D34 RID: 3380
		XBox360_LeftStick_DPadSouth,
		// Token: 0x04000D35 RID: 3381
		XBox360_LeftStick_DPadWest,
		// Token: 0x04000D36 RID: 3382
		XBox360_LeftStick_DPadEast,
		// Token: 0x04000D37 RID: 3383
		XBox360_RightStick_Move,
		// Token: 0x04000D38 RID: 3384
		XBox360_RightStick_Click,
		// Token: 0x04000D39 RID: 3385
		XBox360_RightStick_DPadNorth,
		// Token: 0x04000D3A RID: 3386
		XBox360_RightStick_DPadSouth,
		// Token: 0x04000D3B RID: 3387
		XBox360_RightStick_DPadWest,
		// Token: 0x04000D3C RID: 3388
		XBox360_RightStick_DPadEast,
		// Token: 0x04000D3D RID: 3389
		XBox360_DPad_North,
		// Token: 0x04000D3E RID: 3390
		XBox360_DPad_South,
		// Token: 0x04000D3F RID: 3391
		XBox360_DPad_West,
		// Token: 0x04000D40 RID: 3392
		XBox360_DPad_East,
		// Token: 0x04000D41 RID: 3393
		SteamV2_A,
		// Token: 0x04000D42 RID: 3394
		SteamV2_B,
		// Token: 0x04000D43 RID: 3395
		SteamV2_X,
		// Token: 0x04000D44 RID: 3396
		SteamV2_Y,
		// Token: 0x04000D45 RID: 3397
		SteamV2_LeftBumper,
		// Token: 0x04000D46 RID: 3398
		SteamV2_RightBumper,
		// Token: 0x04000D47 RID: 3399
		SteamV2_LeftGrip_Lower,
		// Token: 0x04000D48 RID: 3400
		SteamV2_LeftGrip_Upper,
		// Token: 0x04000D49 RID: 3401
		SteamV2_RightGrip_Lower,
		// Token: 0x04000D4A RID: 3402
		SteamV2_RightGrip_Upper,
		// Token: 0x04000D4B RID: 3403
		SteamV2_LeftBumper_Pressure,
		// Token: 0x04000D4C RID: 3404
		SteamV2_RightBumper_Pressure,
		// Token: 0x04000D4D RID: 3405
		SteamV2_LeftGrip_Pressure,
		// Token: 0x04000D4E RID: 3406
		SteamV2_RightGrip_Pressure,
		// Token: 0x04000D4F RID: 3407
		SteamV2_LeftGrip_Upper_Pressure,
		// Token: 0x04000D50 RID: 3408
		SteamV2_RightGrip_Upper_Pressure,
		// Token: 0x04000D51 RID: 3409
		SteamV2_Start,
		// Token: 0x04000D52 RID: 3410
		SteamV2_Back,
		// Token: 0x04000D53 RID: 3411
		SteamV2_LeftPad_Touch,
		// Token: 0x04000D54 RID: 3412
		SteamV2_LeftPad_Swipe,
		// Token: 0x04000D55 RID: 3413
		SteamV2_LeftPad_Click,
		// Token: 0x04000D56 RID: 3414
		SteamV2_LeftPad_Pressure,
		// Token: 0x04000D57 RID: 3415
		SteamV2_LeftPad_DPadNorth,
		// Token: 0x04000D58 RID: 3416
		SteamV2_LeftPad_DPadSouth,
		// Token: 0x04000D59 RID: 3417
		SteamV2_LeftPad_DPadWest,
		// Token: 0x04000D5A RID: 3418
		SteamV2_LeftPad_DPadEast,
		// Token: 0x04000D5B RID: 3419
		SteamV2_RightPad_Touch,
		// Token: 0x04000D5C RID: 3420
		SteamV2_RightPad_Swipe,
		// Token: 0x04000D5D RID: 3421
		SteamV2_RightPad_Click,
		// Token: 0x04000D5E RID: 3422
		SteamV2_RightPad_Pressure,
		// Token: 0x04000D5F RID: 3423
		SteamV2_RightPad_DPadNorth,
		// Token: 0x04000D60 RID: 3424
		SteamV2_RightPad_DPadSouth,
		// Token: 0x04000D61 RID: 3425
		SteamV2_RightPad_DPadWest,
		// Token: 0x04000D62 RID: 3426
		SteamV2_RightPad_DPadEast,
		// Token: 0x04000D63 RID: 3427
		SteamV2_LeftTrigger_Pull,
		// Token: 0x04000D64 RID: 3428
		SteamV2_LeftTrigger_Click,
		// Token: 0x04000D65 RID: 3429
		SteamV2_RightTrigger_Pull,
		// Token: 0x04000D66 RID: 3430
		SteamV2_RightTrigger_Click,
		// Token: 0x04000D67 RID: 3431
		SteamV2_LeftStick_Move,
		// Token: 0x04000D68 RID: 3432
		SteamV2_LeftStick_Click,
		// Token: 0x04000D69 RID: 3433
		SteamV2_LeftStick_DPadNorth,
		// Token: 0x04000D6A RID: 3434
		SteamV2_LeftStick_DPadSouth,
		// Token: 0x04000D6B RID: 3435
		SteamV2_LeftStick_DPadWest,
		// Token: 0x04000D6C RID: 3436
		SteamV2_LeftStick_DPadEast,
		// Token: 0x04000D6D RID: 3437
		SteamV2_Gyro_Move,
		// Token: 0x04000D6E RID: 3438
		SteamV2_Gyro_Pitch,
		// Token: 0x04000D6F RID: 3439
		SteamV2_Gyro_Yaw,
		// Token: 0x04000D70 RID: 3440
		SteamV2_Gyro_Roll,
		// Token: 0x04000D71 RID: 3441
		Switch_A,
		// Token: 0x04000D72 RID: 3442
		Switch_B,
		// Token: 0x04000D73 RID: 3443
		Switch_X,
		// Token: 0x04000D74 RID: 3444
		Switch_Y,
		// Token: 0x04000D75 RID: 3445
		Switch_LeftBumper,
		// Token: 0x04000D76 RID: 3446
		Switch_RightBumper,
		// Token: 0x04000D77 RID: 3447
		Switch_Plus,
		// Token: 0x04000D78 RID: 3448
		Switch_Minus,
		// Token: 0x04000D79 RID: 3449
		Switch_Capture,
		// Token: 0x04000D7A RID: 3450
		Switch_LeftTrigger_Pull,
		// Token: 0x04000D7B RID: 3451
		Switch_LeftTrigger_Click,
		// Token: 0x04000D7C RID: 3452
		Switch_RightTrigger_Pull,
		// Token: 0x04000D7D RID: 3453
		Switch_RightTrigger_Click,
		// Token: 0x04000D7E RID: 3454
		Switch_LeftStick_Move,
		// Token: 0x04000D7F RID: 3455
		Switch_LeftStick_Click,
		// Token: 0x04000D80 RID: 3456
		Switch_LeftStick_DPadNorth,
		// Token: 0x04000D81 RID: 3457
		Switch_LeftStick_DPadSouth,
		// Token: 0x04000D82 RID: 3458
		Switch_LeftStick_DPadWest,
		// Token: 0x04000D83 RID: 3459
		Switch_LeftStick_DPadEast,
		// Token: 0x04000D84 RID: 3460
		Switch_RightStick_Move,
		// Token: 0x04000D85 RID: 3461
		Switch_RightStick_Click,
		// Token: 0x04000D86 RID: 3462
		Switch_RightStick_DPadNorth,
		// Token: 0x04000D87 RID: 3463
		Switch_RightStick_DPadSouth,
		// Token: 0x04000D88 RID: 3464
		Switch_RightStick_DPadWest,
		// Token: 0x04000D89 RID: 3465
		Switch_RightStick_DPadEast,
		// Token: 0x04000D8A RID: 3466
		Switch_DPad_North,
		// Token: 0x04000D8B RID: 3467
		Switch_DPad_South,
		// Token: 0x04000D8C RID: 3468
		Switch_DPad_West,
		// Token: 0x04000D8D RID: 3469
		Switch_DPad_East,
		// Token: 0x04000D8E RID: 3470
		Switch_ProGyro_Move,
		// Token: 0x04000D8F RID: 3471
		Switch_ProGyro_Pitch,
		// Token: 0x04000D90 RID: 3472
		Switch_ProGyro_Yaw,
		// Token: 0x04000D91 RID: 3473
		Switch_ProGyro_Roll,
		// Token: 0x04000D92 RID: 3474
		Switch_RightGyro_Move,
		// Token: 0x04000D93 RID: 3475
		Switch_RightGyro_Pitch,
		// Token: 0x04000D94 RID: 3476
		Switch_RightGyro_Yaw,
		// Token: 0x04000D95 RID: 3477
		Switch_RightGyro_Roll,
		// Token: 0x04000D96 RID: 3478
		Switch_LeftGyro_Move,
		// Token: 0x04000D97 RID: 3479
		Switch_LeftGyro_Pitch,
		// Token: 0x04000D98 RID: 3480
		Switch_LeftGyro_Yaw,
		// Token: 0x04000D99 RID: 3481
		Switch_LeftGyro_Roll,
		// Token: 0x04000D9A RID: 3482
		Switch_LeftGrip_Lower,
		// Token: 0x04000D9B RID: 3483
		Switch_LeftGrip_Upper,
		// Token: 0x04000D9C RID: 3484
		Switch_RightGrip_Lower,
		// Token: 0x04000D9D RID: 3485
		Switch_RightGrip_Upper,
		// Token: 0x04000D9E RID: 3486
		PS4_DPad_Move,
		// Token: 0x04000D9F RID: 3487
		XBoxOne_DPad_Move,
		// Token: 0x04000DA0 RID: 3488
		XBox360_DPad_Move,
		// Token: 0x04000DA1 RID: 3489
		Switch_DPad_Move,
		// Token: 0x04000DA2 RID: 3490
		PS5_X,
		// Token: 0x04000DA3 RID: 3491
		PS5_Circle,
		// Token: 0x04000DA4 RID: 3492
		PS5_Triangle,
		// Token: 0x04000DA5 RID: 3493
		PS5_Square,
		// Token: 0x04000DA6 RID: 3494
		PS5_LeftBumper,
		// Token: 0x04000DA7 RID: 3495
		PS5_RightBumper,
		// Token: 0x04000DA8 RID: 3496
		PS5_Option,
		// Token: 0x04000DA9 RID: 3497
		PS5_Create,
		// Token: 0x04000DAA RID: 3498
		PS5_Mute,
		// Token: 0x04000DAB RID: 3499
		PS5_LeftPad_Touch,
		// Token: 0x04000DAC RID: 3500
		PS5_LeftPad_Swipe,
		// Token: 0x04000DAD RID: 3501
		PS5_LeftPad_Click,
		// Token: 0x04000DAE RID: 3502
		PS5_LeftPad_DPadNorth,
		// Token: 0x04000DAF RID: 3503
		PS5_LeftPad_DPadSouth,
		// Token: 0x04000DB0 RID: 3504
		PS5_LeftPad_DPadWest,
		// Token: 0x04000DB1 RID: 3505
		PS5_LeftPad_DPadEast,
		// Token: 0x04000DB2 RID: 3506
		PS5_RightPad_Touch,
		// Token: 0x04000DB3 RID: 3507
		PS5_RightPad_Swipe,
		// Token: 0x04000DB4 RID: 3508
		PS5_RightPad_Click,
		// Token: 0x04000DB5 RID: 3509
		PS5_RightPad_DPadNorth,
		// Token: 0x04000DB6 RID: 3510
		PS5_RightPad_DPadSouth,
		// Token: 0x04000DB7 RID: 3511
		PS5_RightPad_DPadWest,
		// Token: 0x04000DB8 RID: 3512
		PS5_RightPad_DPadEast,
		// Token: 0x04000DB9 RID: 3513
		PS5_CenterPad_Touch,
		// Token: 0x04000DBA RID: 3514
		PS5_CenterPad_Swipe,
		// Token: 0x04000DBB RID: 3515
		PS5_CenterPad_Click,
		// Token: 0x04000DBC RID: 3516
		PS5_CenterPad_DPadNorth,
		// Token: 0x04000DBD RID: 3517
		PS5_CenterPad_DPadSouth,
		// Token: 0x04000DBE RID: 3518
		PS5_CenterPad_DPadWest,
		// Token: 0x04000DBF RID: 3519
		PS5_CenterPad_DPadEast,
		// Token: 0x04000DC0 RID: 3520
		PS5_LeftTrigger_Pull,
		// Token: 0x04000DC1 RID: 3521
		PS5_LeftTrigger_Click,
		// Token: 0x04000DC2 RID: 3522
		PS5_RightTrigger_Pull,
		// Token: 0x04000DC3 RID: 3523
		PS5_RightTrigger_Click,
		// Token: 0x04000DC4 RID: 3524
		PS5_LeftStick_Move,
		// Token: 0x04000DC5 RID: 3525
		PS5_LeftStick_Click,
		// Token: 0x04000DC6 RID: 3526
		PS5_LeftStick_DPadNorth,
		// Token: 0x04000DC7 RID: 3527
		PS5_LeftStick_DPadSouth,
		// Token: 0x04000DC8 RID: 3528
		PS5_LeftStick_DPadWest,
		// Token: 0x04000DC9 RID: 3529
		PS5_LeftStick_DPadEast,
		// Token: 0x04000DCA RID: 3530
		PS5_RightStick_Move,
		// Token: 0x04000DCB RID: 3531
		PS5_RightStick_Click,
		// Token: 0x04000DCC RID: 3532
		PS5_RightStick_DPadNorth,
		// Token: 0x04000DCD RID: 3533
		PS5_RightStick_DPadSouth,
		// Token: 0x04000DCE RID: 3534
		PS5_RightStick_DPadWest,
		// Token: 0x04000DCF RID: 3535
		PS5_RightStick_DPadEast,
		// Token: 0x04000DD0 RID: 3536
		PS5_DPad_Move,
		// Token: 0x04000DD1 RID: 3537
		PS5_DPad_North,
		// Token: 0x04000DD2 RID: 3538
		PS5_DPad_South,
		// Token: 0x04000DD3 RID: 3539
		PS5_DPad_West,
		// Token: 0x04000DD4 RID: 3540
		PS5_DPad_East,
		// Token: 0x04000DD5 RID: 3541
		PS5_Gyro_Move,
		// Token: 0x04000DD6 RID: 3542
		PS5_Gyro_Pitch,
		// Token: 0x04000DD7 RID: 3543
		PS5_Gyro_Yaw,
		// Token: 0x04000DD8 RID: 3544
		PS5_Gyro_Roll,
		// Token: 0x04000DD9 RID: 3545
		XBoxOne_LeftGrip_Lower,
		// Token: 0x04000DDA RID: 3546
		XBoxOne_LeftGrip_Upper,
		// Token: 0x04000DDB RID: 3547
		XBoxOne_RightGrip_Lower,
		// Token: 0x04000DDC RID: 3548
		XBoxOne_RightGrip_Upper,
		// Token: 0x04000DDD RID: 3549
		XBoxOne_Share,
		// Token: 0x04000DDE RID: 3550
		SteamDeck_A,
		// Token: 0x04000DDF RID: 3551
		SteamDeck_B,
		// Token: 0x04000DE0 RID: 3552
		SteamDeck_X,
		// Token: 0x04000DE1 RID: 3553
		SteamDeck_Y,
		// Token: 0x04000DE2 RID: 3554
		SteamDeck_L1,
		// Token: 0x04000DE3 RID: 3555
		SteamDeck_R1,
		// Token: 0x04000DE4 RID: 3556
		SteamDeck_Menu,
		// Token: 0x04000DE5 RID: 3557
		SteamDeck_View,
		// Token: 0x04000DE6 RID: 3558
		SteamDeck_LeftPad_Touch,
		// Token: 0x04000DE7 RID: 3559
		SteamDeck_LeftPad_Swipe,
		// Token: 0x04000DE8 RID: 3560
		SteamDeck_LeftPad_Click,
		// Token: 0x04000DE9 RID: 3561
		SteamDeck_LeftPad_DPadNorth,
		// Token: 0x04000DEA RID: 3562
		SteamDeck_LeftPad_DPadSouth,
		// Token: 0x04000DEB RID: 3563
		SteamDeck_LeftPad_DPadWest,
		// Token: 0x04000DEC RID: 3564
		SteamDeck_LeftPad_DPadEast,
		// Token: 0x04000DED RID: 3565
		SteamDeck_RightPad_Touch,
		// Token: 0x04000DEE RID: 3566
		SteamDeck_RightPad_Swipe,
		// Token: 0x04000DEF RID: 3567
		SteamDeck_RightPad_Click,
		// Token: 0x04000DF0 RID: 3568
		SteamDeck_RightPad_DPadNorth,
		// Token: 0x04000DF1 RID: 3569
		SteamDeck_RightPad_DPadSouth,
		// Token: 0x04000DF2 RID: 3570
		SteamDeck_RightPad_DPadWest,
		// Token: 0x04000DF3 RID: 3571
		SteamDeck_RightPad_DPadEast,
		// Token: 0x04000DF4 RID: 3572
		SteamDeck_L2_SoftPull,
		// Token: 0x04000DF5 RID: 3573
		SteamDeck_L2,
		// Token: 0x04000DF6 RID: 3574
		SteamDeck_R2_SoftPull,
		// Token: 0x04000DF7 RID: 3575
		SteamDeck_R2,
		// Token: 0x04000DF8 RID: 3576
		SteamDeck_LeftStick_Move,
		// Token: 0x04000DF9 RID: 3577
		SteamDeck_L3,
		// Token: 0x04000DFA RID: 3578
		SteamDeck_LeftStick_DPadNorth,
		// Token: 0x04000DFB RID: 3579
		SteamDeck_LeftStick_DPadSouth,
		// Token: 0x04000DFC RID: 3580
		SteamDeck_LeftStick_DPadWest,
		// Token: 0x04000DFD RID: 3581
		SteamDeck_LeftStick_DPadEast,
		// Token: 0x04000DFE RID: 3582
		SteamDeck_LeftStick_Touch,
		// Token: 0x04000DFF RID: 3583
		SteamDeck_RightStick_Move,
		// Token: 0x04000E00 RID: 3584
		SteamDeck_R3,
		// Token: 0x04000E01 RID: 3585
		SteamDeck_RightStick_DPadNorth,
		// Token: 0x04000E02 RID: 3586
		SteamDeck_RightStick_DPadSouth,
		// Token: 0x04000E03 RID: 3587
		SteamDeck_RightStick_DPadWest,
		// Token: 0x04000E04 RID: 3588
		SteamDeck_RightStick_DPadEast,
		// Token: 0x04000E05 RID: 3589
		SteamDeck_RightStick_Touch,
		// Token: 0x04000E06 RID: 3590
		SteamDeck_L4,
		// Token: 0x04000E07 RID: 3591
		SteamDeck_R4,
		// Token: 0x04000E08 RID: 3592
		SteamDeck_L5,
		// Token: 0x04000E09 RID: 3593
		SteamDeck_R5,
		// Token: 0x04000E0A RID: 3594
		SteamDeck_DPad_Move,
		// Token: 0x04000E0B RID: 3595
		SteamDeck_DPad_North,
		// Token: 0x04000E0C RID: 3596
		SteamDeck_DPad_South,
		// Token: 0x04000E0D RID: 3597
		SteamDeck_DPad_West,
		// Token: 0x04000E0E RID: 3598
		SteamDeck_DPad_East,
		// Token: 0x04000E0F RID: 3599
		SteamDeck_Gyro_Move,
		// Token: 0x04000E10 RID: 3600
		SteamDeck_Gyro_Pitch,
		// Token: 0x04000E11 RID: 3601
		SteamDeck_Gyro_Yaw,
		// Token: 0x04000E12 RID: 3602
		SteamDeck_Gyro_Roll,
		// Token: 0x04000E13 RID: 3603
		SteamDeck_Reserved1,
		// Token: 0x04000E14 RID: 3604
		SteamDeck_Reserved2,
		// Token: 0x04000E15 RID: 3605
		SteamDeck_Reserved3,
		// Token: 0x04000E16 RID: 3606
		SteamDeck_Reserved4,
		// Token: 0x04000E17 RID: 3607
		SteamDeck_Reserved5,
		// Token: 0x04000E18 RID: 3608
		SteamDeck_Reserved6,
		// Token: 0x04000E19 RID: 3609
		SteamDeck_Reserved7,
		// Token: 0x04000E1A RID: 3610
		SteamDeck_Reserved8,
		// Token: 0x04000E1B RID: 3611
		SteamDeck_Reserved9,
		// Token: 0x04000E1C RID: 3612
		SteamDeck_Reserved10,
		// Token: 0x04000E1D RID: 3613
		SteamDeck_Reserved11,
		// Token: 0x04000E1E RID: 3614
		SteamDeck_Reserved12,
		// Token: 0x04000E1F RID: 3615
		SteamDeck_Reserved13,
		// Token: 0x04000E20 RID: 3616
		SteamDeck_Reserved14,
		// Token: 0x04000E21 RID: 3617
		SteamDeck_Reserved15,
		// Token: 0x04000E22 RID: 3618
		SteamDeck_Reserved16,
		// Token: 0x04000E23 RID: 3619
		SteamDeck_Reserved17,
		// Token: 0x04000E24 RID: 3620
		SteamDeck_Reserved18,
		// Token: 0x04000E25 RID: 3621
		SteamDeck_Reserved19,
		// Token: 0x04000E26 RID: 3622
		SteamDeck_Reserved20,
		// Token: 0x04000E27 RID: 3623
		Count,
		// Token: 0x04000E28 RID: 3624
		MaximumPossibleValue = 32767
	}
}
