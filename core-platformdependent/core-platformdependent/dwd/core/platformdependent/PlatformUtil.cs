using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platformdependent
{
	// Token: 0x02000027 RID: 39
	public static class PlatformUtil : Object
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00006D24 File Offset: 0x00004F24
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformUtil()
		{
			Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr);
			PlatformUtil.NativeFieldInfoPtr_UNINITIALIZED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, "UNINITIALIZED");
			PlatformUtil.NativeFieldInfoPtr_projectPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, "projectPlatform");
			PlatformUtil.NativeMethodInfoPtr_findProjectPlatformUtil_Private_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663440);
			PlatformUtil.NativeMethodInfoPtr_get_ProjectPlatform_Public_Static_get_IPlatformUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663441);
			PlatformUtil.NativeMethodInfoPtr_set_ProjectPlatform_Public_Static_set_Void_IPlatformUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663442);
			PlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663443);
			PlatformUtil.NativeMethodInfoPtr_GetDiagonalScreenSize_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663444);
			PlatformUtil.NativeMethodInfoPtr_IsTabletBasedOnDiagonalSize_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663445);
			PlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663446);
			PlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663447);
			PlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663448);
			PlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663449);
			PlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663450);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006E58 File Offset: 0x00005058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239715, RefRangeEnd = 1239716, XrefRangeStart = 1239675, XrefRangeEnd = 1239715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type findProjectPlatformUtil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_findProjectPlatformUtil_Private_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006E8C File Offset: 0x0000508C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00006EC0 File Offset: 0x000050C0
		public unsafe static IPlatformUtil ProjectPlatform
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1239739, RefRangeEnd = 1239760, XrefRangeStart = 1239716, XrefRangeEnd = 1239739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_get_ProjectPlatform_Public_Static_get_IPlatformUtil_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlatformUtil>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239760, XrefRangeEnd = 1239764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_set_ProjectPlatform_Public_Static_set_Void_IPlatformUtil_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006EF8 File Offset: 0x000050F8
		public unsafe static Il2CppStringArray Platforms
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239764, XrefRangeEnd = 1239769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_get_Platforms_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006F2C File Offset: 0x0000512C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239779, RefRangeEnd = 1239781, XrefRangeStart = 1239769, XrefRangeEnd = 1239779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDiagonalScreenSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_GetDiagonalScreenSize_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006F5C File Offset: 0x0000515C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239787, RefRangeEnd = 1239788, XrefRangeStart = 1239781, XrefRangeEnd = 1239787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTabletBasedOnDiagonalSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_IsTabletBasedOnDiagonalSize_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006F8C File Offset: 0x0000518C
		public unsafe static uint DefaultPlatform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1239793, RefRangeEnd = 1239794, XrefRangeStart = 1239788, XrefRangeEnd = 1239793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_get_DefaultPlatform_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006FBC File Offset: 0x000051BC
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00006FEC File Offset: 0x000051EC
		public unsafe static uint CurrentPlatform
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1239799, RefRangeEnd = 1239815, XrefRangeStart = 1239794, XrefRangeEnd = 1239799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_get_CurrentPlatform_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1239821, RefRangeEnd = 1239823, XrefRangeStart = 1239815, XrefRangeEnd = 1239821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_set_CurrentPlatform_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007020 File Offset: 0x00005220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239823, XrefRangeEnd = 1239828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdatePlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_UpdatePlatform_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00007048 File Offset: 0x00005248
		public unsafe static string CurrentPlatformAsString
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1239833, RefRangeEnd = 1239857, XrefRangeStart = 1239828, XrefRangeEnd = 1239833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000029A6 File Offset: 0x00000BA6
		public PlatformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00007074 File Offset: 0x00005274
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000029AF File Offset: 0x00000BAF
		public unsafe static uint UNINITIALIZED
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(PlatformUtil.NativeFieldInfoPtr_UNINITIALIZED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformUtil.NativeFieldInfoPtr_UNINITIALIZED, (void*)(&value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00007090 File Offset: 0x00005290
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000029BD File Offset: 0x00000BBD
		public unsafe static IPlatformUtil projectPlatform
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformUtil.NativeFieldInfoPtr_projectPlatform, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlatformUtil>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformUtil.NativeFieldInfoPtr_projectPlatform, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_UNINITIALIZED;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_projectPlatform;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_findProjectPlatformUtil_Private_Static_Type_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectPlatform_Public_Static_get_IPlatformUtil_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectPlatform_Public_Static_set_Void_IPlatformUtil_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_Platforms_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetDiagonalScreenSize_Public_Static_Single_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_IsTabletBasedOnDiagonalSize_Public_Static_Boolean_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPlatform_Public_Static_get_UInt32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatform_Public_Static_get_UInt32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlatform_Public_Static_set_Void_UInt32_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlatform_Public_Static_Void_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlatformAsString_Public_Static_get_String_0;

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("dwd.core.platformdependent.PlatformUtil+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000224 RID: 548 RVA: 0x000092F0 File Offset: 0x000074F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr);
				PlatformUtil.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr, "<>9");
				PlatformUtil.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr, "<>9__1_0");
				PlatformUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr, 100663452);
				PlatformUtil.__c.NativeMethodInfoPtr__findProjectPlatformUtil_b__1_0_Internal_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr, 100663453);
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000936C File Offset: 0x0000756C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformUtil.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000226 RID: 550 RVA: 0x000093A8 File Offset: 0x000075A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _findProjectPlatformUtil_b__1_0(Exception x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.__c.NativeMethodInfoPtr__findProjectPlatformUtil_b__1_0_Internal_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000227 RID: 551 RVA: 0x00003071 File Offset: 0x00001271
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000228 RID: 552 RVA: 0x000093F0 File Offset: 0x000075F0
			// (set) Token: 0x06000229 RID: 553 RVA: 0x0000307A File Offset: 0x0000127A
			public unsafe static PlatformUtil.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformUtil.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformUtil.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformUtil.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600022A RID: 554 RVA: 0x00009418 File Offset: 0x00007618
			// (set) Token: 0x0600022B RID: 555 RVA: 0x0000308C File Offset: 0x0000128C
			public unsafe static Func<Exception, string> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformUtil.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformUtil.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr__findProjectPlatformUtil_b__1_0_Internal_String_Exception_0;
		}
	}
}
