using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.social
{
	// Token: 0x02000007 RID: 7
	public class UnitySocialProvider : MonoBehaviour
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002954 File Offset: 0x00000B54
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySocialProvider()
		{
			Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-achievements.dll", "dwd.core.social", "UnitySocialProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr);
			UnitySocialProvider.NativeFieldInfoPtr_COMPLETED_PROGRESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "COMPLETED_PROGRESS");
			UnitySocialProvider.NativeFieldInfoPtr_completedAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "completedAchievements");
			UnitySocialProvider.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "<Initialized>k__BackingField");
			UnitySocialProvider.NativeFieldInfoPtr__UserLoggedIn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "<UserLoggedIn>k__BackingField");
			UnitySocialProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663308);
			UnitySocialProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663309);
			UnitySocialProvider.NativeMethodInfoPtr_get_UserLoggedIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663310);
			UnitySocialProvider.NativeMethodInfoPtr_set_UserLoggedIn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663311);
			UnitySocialProvider.NativeMethodInfoPtr_Initialize_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663312);
			UnitySocialProvider.NativeMethodInfoPtr_Reinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663313);
			UnitySocialProvider.NativeMethodInfoPtr_IsCompleted_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663314);
			UnitySocialProvider.NativeMethodInfoPtr_ReportProgress_Public_Void_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663315);
			UnitySocialProvider.NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663316);
			UnitySocialProvider.NativeMethodInfoPtr_ShowAchievementUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663317);
			UnitySocialProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, 100663318);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002AB0 File Offset: 0x00000CB0
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002AEC File Offset: 0x00000CEC
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002B2C File Offset: 0x00000D2C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002B68 File Offset: 0x00000D68
		public unsafe bool UserLoggedIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_get_UserLoggedIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_set_UserLoggedIn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002BA8 File Offset: 0x00000DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273189, RefRangeEnd = 1273190, XrefRangeStart = 1273184, XrefRangeEnd = 1273189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_Initialize_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002BE8 File Offset: 0x00000DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273190, XrefRangeEnd = 1273196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_Reinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002C1C File Offset: 0x00000E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273196, XrefRangeEnd = 1273200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCompleted(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_IsCompleted_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002C6C File Offset: 0x00000E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273227, RefRangeEnd = 1273228, XrefRangeStart = 1273200, XrefRangeEnd = 1273227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportProgress(string id, double progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_ReportProgress_Public_Void_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002CBC File Offset: 0x00000EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273228, XrefRangeEnd = 1273229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002D00 File Offset: 0x00000F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273229, XrefRangeEnd = 1273230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAchievementUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr_ShowAchievementUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002D34 File Offset: 0x00000F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273230, XrefRangeEnd = 1273238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySocialProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002168 File Offset: 0x00000368
		public UnitySocialProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002D70 File Offset: 0x00000F70
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002171 File Offset: 0x00000371
		public unsafe static double COMPLETED_PROGRESS
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(UnitySocialProvider.NativeFieldInfoPtr_COMPLETED_PROGRESS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnitySocialProvider.NativeFieldInfoPtr_COMPLETED_PROGRESS, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002D8C File Offset: 0x00000F8C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000217F File Offset: 0x0000037F
		public unsafe HashSet<string> completedAchievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr_completedAchievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr_completedAchievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002DBC File Offset: 0x00000FBC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000219E File Offset: 0x0000039E
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002DE4 File Offset: 0x00000FE4
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000021B9 File Offset: 0x000003B9
		public unsafe bool _UserLoggedIn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr__UserLoggedIn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.NativeFieldInfoPtr__UserLoggedIn_k__BackingField)) = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_COMPLETED_PROGRESS;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_completedAchievements;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__UserLoggedIn_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_UserLoggedIn_Public_get_Boolean_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_UserLoggedIn_Private_set_Void_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_IEnumerator_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Reinitialize_Public_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_IsCompleted_Public_Boolean_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Void_String_Double_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementUI_Public_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000A RID: 10
		[ObfuscatedName("dwd.core.social.UnitySocialProvider+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600004A RID: 74 RVA: 0x00002FFC File Offset: 0x000011FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr);
				UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr, "id");
				UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr, "progress");
				UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				UnitySocialProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr, 100663319);
				UnitySocialProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ReportProgress_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr, 100663320);
			}

			// Token: 0x0600004B RID: 75 RVA: 0x0000308C File Offset: 0x0000128C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySocialProvider.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600004C RID: 76 RVA: 0x000030C8 File Offset: 0x000012C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273160, XrefRangeEnd = 1273179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReportProgress_b__0(bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ReportProgress_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600004D RID: 77 RVA: 0x000022A3 File Offset: 0x000004A3
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00003108 File Offset: 0x00001308
			// (set) Token: 0x0600004F RID: 79 RVA: 0x000022AC File Offset: 0x000004AC
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00003130 File Offset: 0x00001330
			// (set) Token: 0x06000051 RID: 81 RVA: 0x000022CB File Offset: 0x000004CB
			public unsafe double progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_progress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_progress)) = value;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00003158 File Offset: 0x00001358
			// (set) Token: 0x06000053 RID: 83 RVA: 0x000022E6 File Offset: 0x000004E6
			public unsafe UnitySocialProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitySocialProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000028 RID: 40
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04000029 RID: 41
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x0400002A RID: 42
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400002B RID: 43
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400002C RID: 44
			private static readonly IntPtr NativeMethodInfoPtr__ReportProgress_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x0200000B RID: 11
		[ObfuscatedName("dwd.core.social.UnitySocialProvider+<Initialize>d__10")]
		public sealed class _Initialize_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06000054 RID: 84 RVA: 0x00003188 File Offset: 0x00001388
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__10()
			{
				Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySocialProvider>.NativeClassPtr, "<Initialize>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr);
				UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, "<>1__state");
				UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, "<>2__current");
				UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, "<>4__this");
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663321);
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663322);
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663323);
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663324);
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663325);
				UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr, 100663326);
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00003268 File Offset: 0x00001468
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Initialize_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySocialProvider._Initialize_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000056 RID: 86 RVA: 0x000032B0 File Offset: 0x000014B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x000032E4 File Offset: 0x000014E4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00003320 File Offset: 0x00001520
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000059 RID: 89 RVA: 0x00003360 File Offset: 0x00001560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273179, XrefRangeEnd = 1273184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00003394 File Offset: 0x00001594
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySocialProvider._Initialize_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600005B RID: 91 RVA: 0x00002305 File Offset: 0x00000505
			public _Initialize_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600005C RID: 92 RVA: 0x000033D4 File Offset: 0x000015D4
			// (set) Token: 0x0600005D RID: 93 RVA: 0x0000230E File Offset: 0x0000050E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600005E RID: 94 RVA: 0x000033FC File Offset: 0x000015FC
			// (set) Token: 0x0600005F RID: 95 RVA: 0x00002329 File Offset: 0x00000529
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000060 RID: 96 RVA: 0x0000342C File Offset: 0x0000162C
			// (set) Token: 0x06000061 RID: 97 RVA: 0x00002348 File Offset: 0x00000548
			public unsafe UnitySocialProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitySocialProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySocialProvider._Initialize_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400002D RID: 45
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400002E RID: 46
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400002F RID: 47
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000030 RID: 48
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000031 RID: 49
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000032 RID: 50
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000033 RID: 51
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000034 RID: 52
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000035 RID: 53
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
