using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	[StructLayout(2)]
	public struct GlyphValueRecord
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00006B40 File Offset: 0x00004D40
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphValueRecord()
		{
			Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphValueRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr);
			GlyphValueRecord.NativeFieldInfoPtr_m_XPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_XPlacement");
			GlyphValueRecord.NativeFieldInfoPtr_m_YPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_YPlacement");
			GlyphValueRecord.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_XAdvance");
			GlyphValueRecord.NativeFieldInfoPtr_m_YAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, "m_YAdvance");
			GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663400);
			GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663401);
			GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663402);
			GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663403);
			GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663404);
			GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663405);
			GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_GlyphValueRecord_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663406);
			GlyphValueRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663407);
			GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663408);
			GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, 100663409);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006C88 File Offset: 0x00004E88
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public unsafe float xPlacement
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 644340, RefRangeEnd = 644349, XrefRangeStart = 644340, XrefRangeEnd = 644349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006D1C File Offset: 0x00004F1C
		public unsafe float yPlacement
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644397, RefRangeEnd = 644403, XrefRangeStart = 644397, XrefRangeEnd = 644403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006D50 File Offset: 0x00004F50
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002AF2 File Offset: 0x00000CF2
		public unsafe float xAdvance
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XAdvance = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006D80 File Offset: 0x00004F80
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002AFC File Offset: 0x00000CFC
		public unsafe float yAdvance
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YAdvance = value;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253282, RefRangeEnd = 1253284, XrefRangeStart = 1253282, XrefRangeEnd = 1253282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_GlyphValueRecord_GlyphValueRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006DFC File Offset: 0x00004FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253284, XrefRangeEnd = 1253288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006E2C File Offset: 0x0000502C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253288, XrefRangeEnd = 1253292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006E70 File Offset: 0x00005070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253292, XrefRangeEnd = 1253298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphValueRecord other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphValueRecord.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphValueRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006EB0 File Offset: 0x000050B0
		public static GlyphValueRecord operator *(GlyphValueRecord a, float emScale)
		{
			a.m_XPlacement = a.xPlacement * emScale;
			a.m_YPlacement = a.yPlacement * emScale;
			a.m_XAdvance = a.xAdvance * emScale;
			a.m_YAdvance = a.yAdvance * emScale;
			return a;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00006F04 File Offset: 0x00005104
		public static bool operator ==(GlyphValueRecord lhs, GlyphValueRecord rhs)
		{
			return lhs.m_XPlacement == rhs.m_XPlacement && lhs.m_YPlacement == rhs.m_YPlacement && lhs.m_XAdvance == rhs.m_XAdvance && lhs.m_YAdvance == rhs.m_YAdvance;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006F54 File Offset: 0x00005154
		public static bool operator !=(GlyphValueRecord lhs, GlyphValueRecord rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_m_XPlacement;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_m_YPlacement;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_m_YAdvance;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_GlyphValueRecord_GlyphValueRecord_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphValueRecord_0;

		// Token: 0x04000133 RID: 307
		[FieldOffset(0)]
		public float m_XPlacement;

		// Token: 0x04000134 RID: 308
		[FieldOffset(4)]
		public float m_YPlacement;

		// Token: 0x04000135 RID: 309
		[FieldOffset(8)]
		public float m_XAdvance;

		// Token: 0x04000136 RID: 310
		[FieldOffset(12)]
		public float m_YAdvance;
	}
}
