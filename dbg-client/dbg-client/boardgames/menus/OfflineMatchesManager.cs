using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001A9 RID: 425
	public class OfflineMatchesManager : MonoBehaviour
	{
		// Token: 0x060012EA RID: 4842 RVA: 0x0005AAC4 File Offset: 0x00058CC4
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMatchesManager()
		{
			Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "OfflineMatchesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr);
			OfflineMatchesManager.NativeFieldInfoPtr_assetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, "assetPaths");
			OfflineMatchesManager.NativeMethodInfoPtr_loadMatches_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, 100666072);
			OfflineMatchesManager.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Abstract_Virtual_New_MatchInitData_SaveMetaData_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, 100666073);
			OfflineMatchesManager.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Abstract_Virtual_New_IEnumerable_1_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, 100666074);
			OfflineMatchesManager.NativeMethodInfoPtr_GetMatchInitData_Public_Abstract_Virtual_New_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, 100666075);
			OfflineMatchesManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr, 100666076);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005AB6C File Offset: 0x00058D6C
		[CallerCount(0)]
		public unsafe virtual void loadMatches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchesManager.NativeMethodInfoPtr_loadMatches_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0005ABA8 File Offset: 0x00058DA8
		[CallerCount(0)]
		public unsafe virtual MatchInitData GetSavedGameMatchInitData(SaveMetaData metaData, SaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchesManager.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Abstract_Virtual_New_MatchInitData_SaveMetaData_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0005AC18 File Offset: 0x00058E18
		[CallerCount(0)]
		public unsafe virtual IEnumerable<MatchInitData> GetOfflineMatchesOfType(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchesManager.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Abstract_Virtual_New_IEnumerable_1_MatchInitData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchInitData>>(intPtr3) : null;
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0005AC74 File Offset: 0x00058E74
		[CallerCount(0)]
		public unsafe virtual MatchInitData GetMatchInitData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchesManager.NativeMethodInfoPtr_GetMatchInitData_Public_Abstract_Virtual_New_MatchInitData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0005ACD0 File Offset: 0x00058ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518495, RefRangeEnd = 518496, XrefRangeStart = 518485, XrefRangeEnd = 518495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMatchesManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMatchesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0000AE41 File Offset: 0x00009041
		public OfflineMatchesManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x0005AD0C File Offset: 0x00058F0C
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x0000AE4A File Offset: 0x0000904A
		public unsafe Il2CppStringArray assetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchesManager.NativeFieldInfoPtr_assetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchesManager.NativeFieldInfoPtr_assetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_assetPaths;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_loadMatches_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Abstract_Virtual_New_MatchInitData_SaveMetaData_SaveData_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Abstract_Virtual_New_IEnumerable_1_MatchInitData_String_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchInitData_Public_Abstract_Virtual_New_MatchInitData_String_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
