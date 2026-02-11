using System;

namespace UnityEngine
{
	// Token: 0x020000CB RID: 203
	public enum TextureFormat
	{
		// Token: 0x04000C2C RID: 3116
		Alpha8 = 1,
		// Token: 0x04000C2D RID: 3117
		ARGB4444,
		// Token: 0x04000C2E RID: 3118
		RGB24,
		// Token: 0x04000C2F RID: 3119
		RGBA32,
		// Token: 0x04000C30 RID: 3120
		ARGB32,
		// Token: 0x04000C31 RID: 3121
		RGB565 = 7,
		// Token: 0x04000C32 RID: 3122
		R16 = 9,
		// Token: 0x04000C33 RID: 3123
		DXT1,
		// Token: 0x04000C34 RID: 3124
		DXT5 = 12,
		// Token: 0x04000C35 RID: 3125
		RGBA4444,
		// Token: 0x04000C36 RID: 3126
		BGRA32,
		// Token: 0x04000C37 RID: 3127
		RHalf,
		// Token: 0x04000C38 RID: 3128
		RGHalf,
		// Token: 0x04000C39 RID: 3129
		RGBAHalf,
		// Token: 0x04000C3A RID: 3130
		RFloat,
		// Token: 0x04000C3B RID: 3131
		RGFloat,
		// Token: 0x04000C3C RID: 3132
		RGBAFloat,
		// Token: 0x04000C3D RID: 3133
		YUY2,
		// Token: 0x04000C3E RID: 3134
		RGB9e5Float,
		// Token: 0x04000C3F RID: 3135
		BC4 = 26,
		// Token: 0x04000C40 RID: 3136
		BC5,
		// Token: 0x04000C41 RID: 3137
		BC6H = 24,
		// Token: 0x04000C42 RID: 3138
		BC7,
		// Token: 0x04000C43 RID: 3139
		DXT1Crunched = 28,
		// Token: 0x04000C44 RID: 3140
		DXT5Crunched,
		// Token: 0x04000C45 RID: 3141
		PVRTC_RGB2,
		// Token: 0x04000C46 RID: 3142
		PVRTC_RGBA2,
		// Token: 0x04000C47 RID: 3143
		PVRTC_RGB4,
		// Token: 0x04000C48 RID: 3144
		PVRTC_RGBA4,
		// Token: 0x04000C49 RID: 3145
		ETC_RGB4,
		// Token: 0x04000C4A RID: 3146
		EAC_R = 41,
		// Token: 0x04000C4B RID: 3147
		EAC_R_SIGNED,
		// Token: 0x04000C4C RID: 3148
		EAC_RG,
		// Token: 0x04000C4D RID: 3149
		EAC_RG_SIGNED,
		// Token: 0x04000C4E RID: 3150
		ETC2_RGB,
		// Token: 0x04000C4F RID: 3151
		ETC2_RGBA1,
		// Token: 0x04000C50 RID: 3152
		ETC2_RGBA8,
		// Token: 0x04000C51 RID: 3153
		ASTC_4x4,
		// Token: 0x04000C52 RID: 3154
		ASTC_5x5,
		// Token: 0x04000C53 RID: 3155
		ASTC_6x6,
		// Token: 0x04000C54 RID: 3156
		ASTC_8x8,
		// Token: 0x04000C55 RID: 3157
		ASTC_10x10,
		// Token: 0x04000C56 RID: 3158
		ASTC_12x12,
		// Token: 0x04000C57 RID: 3159
		ETC_RGB4_3DS = 60,
		// Token: 0x04000C58 RID: 3160
		ETC_RGBA8_3DS,
		// Token: 0x04000C59 RID: 3161
		RG16,
		// Token: 0x04000C5A RID: 3162
		R8,
		// Token: 0x04000C5B RID: 3163
		ETC_RGB4Crunched,
		// Token: 0x04000C5C RID: 3164
		ETC2_RGBA8Crunched,
		// Token: 0x04000C5D RID: 3165
		ASTC_HDR_4x4,
		// Token: 0x04000C5E RID: 3166
		ASTC_HDR_5x5,
		// Token: 0x04000C5F RID: 3167
		ASTC_HDR_6x6,
		// Token: 0x04000C60 RID: 3168
		ASTC_HDR_8x8,
		// Token: 0x04000C61 RID: 3169
		ASTC_HDR_10x10,
		// Token: 0x04000C62 RID: 3170
		ASTC_HDR_12x12,
		// Token: 0x04000C63 RID: 3171
		RG32,
		// Token: 0x04000C64 RID: 3172
		RGB48,
		// Token: 0x04000C65 RID: 3173
		RGBA64,
		// Token: 0x04000C66 RID: 3174
		ASTC_RGB_4x4 = 48,
		// Token: 0x04000C67 RID: 3175
		ASTC_RGB_5x5,
		// Token: 0x04000C68 RID: 3176
		ASTC_RGB_6x6,
		// Token: 0x04000C69 RID: 3177
		ASTC_RGB_8x8,
		// Token: 0x04000C6A RID: 3178
		ASTC_RGB_10x10,
		// Token: 0x04000C6B RID: 3179
		ASTC_RGB_12x12,
		// Token: 0x04000C6C RID: 3180
		ASTC_RGBA_4x4,
		// Token: 0x04000C6D RID: 3181
		ASTC_RGBA_5x5,
		// Token: 0x04000C6E RID: 3182
		ASTC_RGBA_6x6,
		// Token: 0x04000C6F RID: 3183
		ASTC_RGBA_8x8,
		// Token: 0x04000C70 RID: 3184
		ASTC_RGBA_10x10,
		// Token: 0x04000C71 RID: 3185
		ASTC_RGBA_12x12
	}
}
