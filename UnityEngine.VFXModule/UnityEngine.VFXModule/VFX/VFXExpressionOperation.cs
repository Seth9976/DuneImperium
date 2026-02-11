using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000011 RID: 17
	public enum VFXExpressionOperation
	{
		// Token: 0x040000E6 RID: 230
		None,
		// Token: 0x040000E7 RID: 231
		Value,
		// Token: 0x040000E8 RID: 232
		Combine2f,
		// Token: 0x040000E9 RID: 233
		Combine3f,
		// Token: 0x040000EA RID: 234
		Combine4f,
		// Token: 0x040000EB RID: 235
		ExtractComponent,
		// Token: 0x040000EC RID: 236
		DeltaTime,
		// Token: 0x040000ED RID: 237
		TotalTime,
		// Token: 0x040000EE RID: 238
		SystemSeed,
		// Token: 0x040000EF RID: 239
		LocalToWorld,
		// Token: 0x040000F0 RID: 240
		WorldToLocal,
		// Token: 0x040000F1 RID: 241
		FrameIndex,
		// Token: 0x040000F2 RID: 242
		PlayRate,
		// Token: 0x040000F3 RID: 243
		UnscaledDeltaTime,
		// Token: 0x040000F4 RID: 244
		ManagerMaxDeltaTime,
		// Token: 0x040000F5 RID: 245
		ManagerFixedTimeStep,
		// Token: 0x040000F6 RID: 246
		GameDeltaTime,
		// Token: 0x040000F7 RID: 247
		GameUnscaledDeltaTime,
		// Token: 0x040000F8 RID: 248
		GameSmoothDeltaTime,
		// Token: 0x040000F9 RID: 249
		GameTotalTime,
		// Token: 0x040000FA RID: 250
		GameUnscaledTotalTime,
		// Token: 0x040000FB RID: 251
		GameTotalTimeSinceSceneLoad,
		// Token: 0x040000FC RID: 252
		GameTimeScale,
		// Token: 0x040000FD RID: 253
		Sin,
		// Token: 0x040000FE RID: 254
		Cos,
		// Token: 0x040000FF RID: 255
		Tan,
		// Token: 0x04000100 RID: 256
		ASin,
		// Token: 0x04000101 RID: 257
		ACos,
		// Token: 0x04000102 RID: 258
		ATan,
		// Token: 0x04000103 RID: 259
		Abs,
		// Token: 0x04000104 RID: 260
		Sign,
		// Token: 0x04000105 RID: 261
		Saturate,
		// Token: 0x04000106 RID: 262
		Ceil,
		// Token: 0x04000107 RID: 263
		Round,
		// Token: 0x04000108 RID: 264
		Frac,
		// Token: 0x04000109 RID: 265
		Floor,
		// Token: 0x0400010A RID: 266
		Log2,
		// Token: 0x0400010B RID: 267
		Mul,
		// Token: 0x0400010C RID: 268
		Divide,
		// Token: 0x0400010D RID: 269
		Add,
		// Token: 0x0400010E RID: 270
		Subtract,
		// Token: 0x0400010F RID: 271
		Min,
		// Token: 0x04000110 RID: 272
		Max,
		// Token: 0x04000111 RID: 273
		Pow,
		// Token: 0x04000112 RID: 274
		ATan2,
		// Token: 0x04000113 RID: 275
		TRSToMatrix,
		// Token: 0x04000114 RID: 276
		InverseMatrix,
		// Token: 0x04000115 RID: 277
		InverseTRSMatrix,
		// Token: 0x04000116 RID: 278
		TransposeMatrix,
		// Token: 0x04000117 RID: 279
		ExtractPositionFromMatrix,
		// Token: 0x04000118 RID: 280
		ExtractAnglesFromMatrix,
		// Token: 0x04000119 RID: 281
		ExtractScaleFromMatrix,
		// Token: 0x0400011A RID: 282
		TransformMatrix,
		// Token: 0x0400011B RID: 283
		TransformPos,
		// Token: 0x0400011C RID: 284
		TransformVec,
		// Token: 0x0400011D RID: 285
		TransformDir,
		// Token: 0x0400011E RID: 286
		TransformVector4,
		// Token: 0x0400011F RID: 287
		Vector3sToMatrix,
		// Token: 0x04000120 RID: 288
		Vector4sToMatrix,
		// Token: 0x04000121 RID: 289
		MatrixToVector3s,
		// Token: 0x04000122 RID: 290
		MatrixToVector4s,
		// Token: 0x04000123 RID: 291
		SampleCurve,
		// Token: 0x04000124 RID: 292
		SampleGradient,
		// Token: 0x04000125 RID: 293
		SampleMeshVertexFloat,
		// Token: 0x04000126 RID: 294
		SampleMeshVertexFloat2,
		// Token: 0x04000127 RID: 295
		SampleMeshVertexFloat3,
		// Token: 0x04000128 RID: 296
		SampleMeshVertexFloat4,
		// Token: 0x04000129 RID: 297
		SampleMeshVertexColor,
		// Token: 0x0400012A RID: 298
		SampleMeshIndex,
		// Token: 0x0400012B RID: 299
		VertexBufferFromMesh,
		// Token: 0x0400012C RID: 300
		VertexBufferFromSkinnedMeshRenderer,
		// Token: 0x0400012D RID: 301
		IndexBufferFromMesh,
		// Token: 0x0400012E RID: 302
		MeshFromSkinnedMeshRenderer,
		// Token: 0x0400012F RID: 303
		RootBoneTransformFromSkinnedMeshRenderer,
		// Token: 0x04000130 RID: 304
		BakeCurve,
		// Token: 0x04000131 RID: 305
		BakeGradient,
		// Token: 0x04000132 RID: 306
		BitwiseLeftShift,
		// Token: 0x04000133 RID: 307
		BitwiseRightShift,
		// Token: 0x04000134 RID: 308
		BitwiseOr,
		// Token: 0x04000135 RID: 309
		BitwiseAnd,
		// Token: 0x04000136 RID: 310
		BitwiseXor,
		// Token: 0x04000137 RID: 311
		BitwiseComplement,
		// Token: 0x04000138 RID: 312
		CastUintToFloat,
		// Token: 0x04000139 RID: 313
		CastIntToFloat,
		// Token: 0x0400013A RID: 314
		CastFloatToUint,
		// Token: 0x0400013B RID: 315
		CastIntToUint,
		// Token: 0x0400013C RID: 316
		CastFloatToInt,
		// Token: 0x0400013D RID: 317
		CastUintToInt,
		// Token: 0x0400013E RID: 318
		CastIntToBool,
		// Token: 0x0400013F RID: 319
		CastUintToBool,
		// Token: 0x04000140 RID: 320
		CastFloatToBool,
		// Token: 0x04000141 RID: 321
		CastBoolToInt,
		// Token: 0x04000142 RID: 322
		CastBoolToUint,
		// Token: 0x04000143 RID: 323
		CastBoolToFloat,
		// Token: 0x04000144 RID: 324
		RGBtoHSV,
		// Token: 0x04000145 RID: 325
		HSVtoRGB,
		// Token: 0x04000146 RID: 326
		Condition,
		// Token: 0x04000147 RID: 327
		Branch,
		// Token: 0x04000148 RID: 328
		GenerateRandom,
		// Token: 0x04000149 RID: 329
		GenerateFixedRandom,
		// Token: 0x0400014A RID: 330
		ExtractMatrixFromMainCamera,
		// Token: 0x0400014B RID: 331
		ExtractFOVFromMainCamera,
		// Token: 0x0400014C RID: 332
		ExtractNearPlaneFromMainCamera,
		// Token: 0x0400014D RID: 333
		ExtractFarPlaneFromMainCamera,
		// Token: 0x0400014E RID: 334
		ExtractAspectRatioFromMainCamera,
		// Token: 0x0400014F RID: 335
		ExtractPixelDimensionsFromMainCamera,
		// Token: 0x04000150 RID: 336
		ExtractScaledPixelDimensionsFromMainCamera,
		// Token: 0x04000151 RID: 337
		ExtractLensShiftFromMainCamera,
		// Token: 0x04000152 RID: 338
		GetBufferFromMainCamera,
		// Token: 0x04000153 RID: 339
		IsMainCameraOrthographic,
		// Token: 0x04000154 RID: 340
		GetOrthographicSizeFromMainCamera,
		// Token: 0x04000155 RID: 341
		LogicalAnd,
		// Token: 0x04000156 RID: 342
		LogicalOr,
		// Token: 0x04000157 RID: 343
		LogicalNot,
		// Token: 0x04000158 RID: 344
		ValueNoise1D,
		// Token: 0x04000159 RID: 345
		ValueNoise2D,
		// Token: 0x0400015A RID: 346
		ValueNoise3D,
		// Token: 0x0400015B RID: 347
		ValueCurlNoise2D,
		// Token: 0x0400015C RID: 348
		ValueCurlNoise3D,
		// Token: 0x0400015D RID: 349
		PerlinNoise1D,
		// Token: 0x0400015E RID: 350
		PerlinNoise2D,
		// Token: 0x0400015F RID: 351
		PerlinNoise3D,
		// Token: 0x04000160 RID: 352
		PerlinCurlNoise2D,
		// Token: 0x04000161 RID: 353
		PerlinCurlNoise3D,
		// Token: 0x04000162 RID: 354
		CellularNoise1D,
		// Token: 0x04000163 RID: 355
		CellularNoise2D,
		// Token: 0x04000164 RID: 356
		CellularNoise3D,
		// Token: 0x04000165 RID: 357
		CellularCurlNoise2D,
		// Token: 0x04000166 RID: 358
		CellularCurlNoise3D,
		// Token: 0x04000167 RID: 359
		VoroNoise2D,
		// Token: 0x04000168 RID: 360
		MeshVertexCount,
		// Token: 0x04000169 RID: 361
		MeshChannelOffset,
		// Token: 0x0400016A RID: 362
		MeshChannelInfos,
		// Token: 0x0400016B RID: 363
		MeshVertexStride,
		// Token: 0x0400016C RID: 364
		MeshIndexCount,
		// Token: 0x0400016D RID: 365
		MeshIndexFormat,
		// Token: 0x0400016E RID: 366
		BufferStride,
		// Token: 0x0400016F RID: 367
		BufferCount,
		// Token: 0x04000170 RID: 368
		TextureWidth,
		// Token: 0x04000171 RID: 369
		TextureHeight,
		// Token: 0x04000172 RID: 370
		TextureDepth,
		// Token: 0x04000173 RID: 371
		ReadEventAttribute,
		// Token: 0x04000174 RID: 372
		SpawnerStateNewLoop,
		// Token: 0x04000175 RID: 373
		SpawnerStateLoopState,
		// Token: 0x04000176 RID: 374
		SpawnerStateSpawnCount,
		// Token: 0x04000177 RID: 375
		SpawnerStateDeltaTime,
		// Token: 0x04000178 RID: 376
		SpawnerStateTotalTime,
		// Token: 0x04000179 RID: 377
		SpawnerStateDelayBeforeLoop,
		// Token: 0x0400017A RID: 378
		SpawnerStateLoopDuration,
		// Token: 0x0400017B RID: 379
		SpawnerStateDelayAfterLoop,
		// Token: 0x0400017C RID: 380
		SpawnerStateLoopIndex,
		// Token: 0x0400017D RID: 381
		SpawnerStateLoopCount
	}
}
