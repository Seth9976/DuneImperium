using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Google.Apis.Requests
{
	// Token: 0x02000016 RID: 22
	public sealed class VersionHeaderBuilder : Object
	{
		// Token: 0x06000177 RID: 375 RVA: 0x0000AB24 File Offset: 0x00008D24
		// Note: this type is marked as 'beforefieldinit'.
		static VersionHeaderBuilder()
		{
			Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "VersionHeaderBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr);
			VersionHeaderBuilder.NativeFieldInfoPtr_s_environmentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, "s_environmentVersion");
			VersionHeaderBuilder.NativeFieldInfoPtr_HeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, "HeaderName");
			VersionHeaderBuilder.NativeFieldInfoPtr__names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, "_names");
			VersionHeaderBuilder.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, "_values");
			VersionHeaderBuilder.NativeMethodInfoPtr_AppendVersion_Public_VersionHeaderBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663620);
			VersionHeaderBuilder.NativeMethodInfoPtr_CheckArgument_Private_Static_Void_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663621);
			VersionHeaderBuilder.NativeMethodInfoPtr_AppendAssemblyVersion_Public_VersionHeaderBuilder_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663622);
			VersionHeaderBuilder.NativeMethodInfoPtr_AppendDotNetEnvironment_Public_VersionHeaderBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663623);
			VersionHeaderBuilder.NativeMethodInfoPtr_GetEnvironmentVersion_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663624);
			VersionHeaderBuilder.NativeMethodInfoPtr_GetEntryAssemblyVersionOrNull_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663625);
			VersionHeaderBuilder.NativeMethodInfoPtr_FormatAssemblyVersion_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663626);
			VersionHeaderBuilder.NativeMethodInfoPtr_FormatVersion_Private_Static_String_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663627);
			VersionHeaderBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663628);
			VersionHeaderBuilder.NativeMethodInfoPtr_Clone_Public_VersionHeaderBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663629);
			VersionHeaderBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, 100663630);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000AC80 File Offset: 0x00008E80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1198854, RefRangeEnd = 1198858, XrefRangeStart = 1198806, XrefRangeEnd = 1198854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionHeaderBuilder AppendVersion(string name, string version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_AppendVersion_Public_VersionHeaderBuilder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr3) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198858, XrefRangeEnd = 1198863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckArgument(bool condition, string paramName, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_CheckArgument_Private_Static_Void_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000AD3C File Offset: 0x00008F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198863, XrefRangeEnd = 1198868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionHeaderBuilder AppendAssemblyVersion(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_AppendAssemblyVersion_Public_VersionHeaderBuilder_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr3) : null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198879, RefRangeEnd = 1198881, XrefRangeStart = 1198868, XrefRangeEnd = 1198879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionHeaderBuilder AppendDotNetEnvironment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_AppendDotNetEnvironment_Public_VersionHeaderBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr3) : null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198881, XrefRangeEnd = 1198889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnvironmentVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_GetEnvironmentVersion_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000AE0C File Offset: 0x0000900C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1198938, RefRangeEnd = 1198939, XrefRangeStart = 1198889, XrefRangeEnd = 1198938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEntryAssemblyVersionOrNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_GetEntryAssemblyVersionOrNull_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000AE38 File Offset: 0x00009038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1198963, RefRangeEnd = 1198966, XrefRangeStart = 1198939, XrefRangeEnd = 1198963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAssemblyVersion(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_FormatAssemblyVersion_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000AE74 File Offset: 0x00009074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1198979, RefRangeEnd = 1198981, XrefRangeStart = 1198966, XrefRangeEnd = 1198979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatVersion(Version version)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_FormatVersion_Private_Static_String_Version_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000AEB0 File Offset: 0x000090B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198981, XrefRangeEnd = 1199018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000AEE8 File Offset: 0x000090E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199018, XrefRangeEnd = 1199027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionHeaderBuilder Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr_Clone_Public_VersionHeaderBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr3) : null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000AF28 File Offset: 0x00009128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1199040, RefRangeEnd = 1199044, XrefRangeStart = 1199027, XrefRangeEnd = 1199040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionHeaderBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000027D2 File Offset: 0x000009D2
		public VersionHeaderBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000AF64 File Offset: 0x00009164
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe static Lazy<string> s_environmentVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionHeaderBuilder.NativeFieldInfoPtr_s_environmentVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionHeaderBuilder.NativeFieldInfoPtr_s_environmentVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000AF8C File Offset: 0x0000918C
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000027ED File Offset: 0x000009ED
		public unsafe static string HeaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionHeaderBuilder.NativeFieldInfoPtr_HeaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionHeaderBuilder.NativeFieldInfoPtr_HeaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000AFAC File Offset: 0x000091AC
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000027FF File Offset: 0x000009FF
		public unsafe List<string> _names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionHeaderBuilder.NativeFieldInfoPtr__names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionHeaderBuilder.NativeFieldInfoPtr__names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000AFDC File Offset: 0x000091DC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000281E File Offset: 0x00000A1E
		public unsafe List<string> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionHeaderBuilder.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionHeaderBuilder.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_s_environmentVersion;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_HeaderName;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr__names;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_AppendVersion_Public_VersionHeaderBuilder_String_String_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_CheckArgument_Private_Static_Void_Boolean_String_String_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_AppendAssemblyVersion_Public_VersionHeaderBuilder_String_Type_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_AppendDotNetEnvironment_Public_VersionHeaderBuilder_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVersion_Private_Static_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryAssemblyVersionOrNull_Private_Static_String_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_FormatAssemblyVersion_Private_Static_String_Type_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_FormatVersion_Private_Static_String_Version_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_VersionHeaderBuilder_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("Google.Apis.Requests.VersionHeaderBuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003E9 RID: 1001 RVA: 0x0001208C File Offset: 0x0001028C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VersionHeaderBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr);
				VersionHeaderBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, "<>9");
				VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, "<>9__9_0");
				VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, "<>9__12_0");
				VersionHeaderBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, 100663633);
				VersionHeaderBuilder.__c.NativeMethodInfoPtr__GetEntryAssemblyVersionOrNull_b__9_0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, 100663634);
				VersionHeaderBuilder.__c.NativeMethodInfoPtr__ToString_b__12_0_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr, 100663635);
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x00012130 File Offset: 0x00010330
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionHeaderBuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x0001216C File Offset: 0x0001036C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198792, XrefRangeEnd = 1198803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEntryAssemblyVersionOrNull_b__9_0(MethodInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.__c.NativeMethodInfoPtr__GetEntryAssemblyVersionOrNull_b__9_0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x000121BC File Offset: 0x000103BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198803, XrefRangeEnd = 1198806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__12_0(string name, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionHeaderBuilder.__c.NativeMethodInfoPtr__ToString_b__12_0_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00004316 File Offset: 0x00002516
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x00012218 File Offset: 0x00010418
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000431F File Offset: 0x0000251F
			public unsafe static VersionHeaderBuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00012240 File Offset: 0x00010440
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00004331 File Offset: 0x00002531
			public unsafe static Func<MethodInfo, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00012268 File Offset: 0x00010468
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00004343 File Offset: 0x00002543
			public unsafe static Func<string, string, string> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VersionHeaderBuilder.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr__GetEntryAssemblyVersionOrNull_b__9_0_Internal_Boolean_MethodInfo_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__12_0_Internal_String_String_String_0;
		}
	}
}
