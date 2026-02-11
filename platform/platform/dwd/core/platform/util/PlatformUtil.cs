using System;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platform.util
{
	// Token: 0x02000044 RID: 68
	public static class PlatformUtil : Object
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformUtil()
		{
			Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.util", "PlatformUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr);
			PlatformUtil.NativeMethodInfoPtr_GetPlatformTokenFromCommandLine_Public_Static_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663640);
			PlatformUtil.NativeMethodInfoPtr_SetFieldsFromDictionary_Public_Static_Void_Type_Object_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663641);
			PlatformUtil.NativeMethodInfoPtr_GetUtcTime_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663642);
			PlatformUtil.NativeMethodInfoPtr_StripFriendCode_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100663643);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168024, RefRangeEnd = 1168025, XrefRangeStart = 1167980, XrefRangeEnd = 1168024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlatformToken GetPlatformTokenFromCommandLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_GetPlatformTokenFromCommandLine_Public_Static_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr3) : null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168175, RefRangeEnd = 1168177, XrefRangeStart = 1168025, XrefRangeEnd = 1168175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFieldsFromDictionary(Type objectType, Object instanceObject, IDictionary<string, Object> fieldData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instanceObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_SetFieldsFromDictionary_Public_Static_Void_Type_Object_IDictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168177, XrefRangeEnd = 1168187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetUtcTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_GetUtcTime_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168190, RefRangeEnd = 1168191, XrefRangeStart = 1168187, XrefRangeEnd = 1168190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripFriendCode(string screenName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(screenName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.NativeMethodInfoPtr_StripFriendCode_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000337C File Offset: 0x0000157C
		public PlatformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformTokenFromCommandLine_Public_Static_PlatformToken_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_SetFieldsFromDictionary_Public_Static_Void_Type_Object_IDictionary_2_String_Object_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_GetUtcTime_Public_Static_Int64_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_StripFriendCode_Public_Static_String_String_0;

		// Token: 0x0200007A RID: 122
		[ObfuscatedName("dwd.core.platform.util.PlatformUtil+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06000483 RID: 1155 RVA: 0x00013FC4 File Offset: 0x000121C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr);
				PlatformUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_tokenString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr, "tokenString");
				PlatformUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr, 100663644);
				PlatformUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__GetPlatformTokenFromCommandLine_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr, 100663645);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x0001402C File Offset: 0x0001222C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformUtil.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00014068 File Offset: 0x00012268
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetPlatformTokenFromCommandLine_b__0(string v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__GetPlatformTokenFromCommandLine_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x0000430E File Offset: 0x0000250E
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000487 RID: 1159 RVA: 0x000140AC File Offset: 0x000122AC
			// (set) Token: 0x06000488 RID: 1160 RVA: 0x00004317 File Offset: 0x00002517
			public unsafe string tokenString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_tokenString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_tokenString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeFieldInfoPtr_tokenString;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeMethodInfoPtr__GetPlatformTokenFromCommandLine_b__0_Internal_Void_String_0;
		}
	}
}
