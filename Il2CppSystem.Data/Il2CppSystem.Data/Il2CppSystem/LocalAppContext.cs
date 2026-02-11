using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000007 RID: 7
	public class LocalAppContext : Object
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000086E8 File Offset: 0x000068E8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAppContext()
		{
			Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System", "LocalAppContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr);
			LocalAppContext.NativeFieldInfoPtr_s_isDisableCachingInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, "s_isDisableCachingInitialized");
			LocalAppContext.NativeFieldInfoPtr_s_disableCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, "s_disableCaching");
			LocalAppContext.NativeFieldInfoPtr_s_syncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, "s_syncObject");
			LocalAppContext.NativeMethodInfoPtr_GetCachedSwitchValue_Internal_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, 100663305);
			LocalAppContext.NativeMethodInfoPtr_GetCachedSwitchValueInternal_Private_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, 100663306);
			LocalAppContext.NativeMethodInfoPtr_get_DisableCaching_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, 100663307);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00008790 File Offset: 0x00006990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886997, XrefRangeEnd = 886998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCachedSwitchValue(string switchName, ref int switchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(switchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &switchValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContext.NativeMethodInfoPtr_GetCachedSwitchValue_Internal_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000087E0 File Offset: 0x000069E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 887023, RefRangeEnd = 887028, XrefRangeStart = 886998, XrefRangeEnd = 887023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(switchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &switchValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContext.NativeMethodInfoPtr_GetCachedSwitchValueInternal_Private_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00008830 File Offset: 0x00006A30
		public unsafe static bool DisableCaching
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887028, XrefRangeEnd = 887049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContext.NativeMethodInfoPtr_get_DisableCaching_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020FE File Offset: 0x000002FE
		public LocalAppContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00008860 File Offset: 0x00006A60
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002107 File Offset: 0x00000307
		public unsafe static bool s_isDisableCachingInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContext.NativeFieldInfoPtr_s_isDisableCachingInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContext.NativeFieldInfoPtr_s_isDisableCachingInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000887C File Offset: 0x00006A7C
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002115 File Offset: 0x00000315
		public unsafe static bool s_disableCaching
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContext.NativeFieldInfoPtr_s_disableCaching, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContext.NativeFieldInfoPtr_s_disableCaching, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00008898 File Offset: 0x00006A98
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002123 File Offset: 0x00000323
		public unsafe static Object s_syncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContext.NativeFieldInfoPtr_s_syncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContext.NativeFieldInfoPtr_s_syncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_s_isDisableCachingInitialized;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_s_disableCaching;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_s_syncObject;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSwitchValue_Internal_Static_Boolean_String_byref_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSwitchValueInternal_Private_Static_Boolean_String_byref_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableCaching_Private_Static_get_Boolean_0;

		// Token: 0x020000CC RID: 204
		[ObfuscatedName("System.LocalAppContext+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001434 RID: 5172 RVA: 0x00060F68 File Offset: 0x0005F168
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalAppContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr);
				LocalAppContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr, "<>9");
				LocalAppContext.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr, "<>9__6_0");
				LocalAppContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr, 100663309);
				LocalAppContext.__c.NativeMethodInfoPtr__get_DisableCaching_b__6_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr, 100663310);
			}

			// Token: 0x06001435 RID: 5173 RVA: 0x00060FE4 File Offset: 0x0005F1E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalAppContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001436 RID: 5174 RVA: 0x00061020 File Offset: 0x0005F220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886991, XrefRangeEnd = 886997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_DisableCaching_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalAppContext.__c.NativeMethodInfoPtr__get_DisableCaching_b__6_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001437 RID: 5175 RVA: 0x00007995 File Offset: 0x00005B95
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06001438 RID: 5176 RVA: 0x0006105C File Offset: 0x0005F25C
			// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000799E File Offset: 0x00005B9E
			public unsafe static LocalAppContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalAppContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalAppContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalAppContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x0600143A RID: 5178 RVA: 0x00061084 File Offset: 0x0005F284
			// (set) Token: 0x0600143B RID: 5179 RVA: 0x000079B0 File Offset: 0x00005BB0
			public unsafe static Func<bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalAppContext.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalAppContext.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010DC RID: 4316
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010DD RID: 4317
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040010DE RID: 4318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010DF RID: 4319
			private static readonly IntPtr NativeMethodInfoPtr__get_DisableCaching_b__6_0_Internal_Boolean_0;
		}
	}
}
