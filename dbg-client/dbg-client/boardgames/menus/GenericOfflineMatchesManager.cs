using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus
{
	// Token: 0x020001A4 RID: 420
	public class GenericOfflineMatchesManager<T> : OfflineMatchesManager where T : MatchInitData
	{
		// Token: 0x060012BF RID: 4799 RVA: 0x00059EE8 File Offset: 0x000580E8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOfflineMatchesManager()
		{
			Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "GenericOfflineMatchesManager`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr);
			GenericOfflineMatchesManager<T>.NativeFieldInfoPtr_allOfflineMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, "allOfflineMatches");
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666046);
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetMatchInitData_Public_Virtual_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666047);
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Virtual_IEnumerable_1_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666048);
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_MatchInitData_SaveMetaData_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666049);
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_loadMatches_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666050);
			GenericOfflineMatchesManager<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr, 100666051);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00059FE0 File Offset: 0x000581E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518247, XrefRangeEnd = 518248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0005A014 File Offset: 0x00058214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518248, XrefRangeEnd = 518249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MatchInitData GetMatchInitData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetMatchInitData_Public_Virtual_MatchInitData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0005A070 File Offset: 0x00058270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518249, XrefRangeEnd = 518250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<MatchInitData> GetOfflineMatchesOfType(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Virtual_IEnumerable_1_MatchInitData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchInitData>>(intPtr3) : null;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0005A0CC File Offset: 0x000582CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518250, XrefRangeEnd = 518251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MatchInitData GetSavedGameMatchInitData(SaveMetaData metaData, SaveData data)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_MatchInitData_SaveMetaData_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005A13C File Offset: 0x0005833C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518251, XrefRangeEnd = 518253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void loadMatches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOfflineMatchesManager<T>.NativeMethodInfoPtr_loadMatches_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0005A178 File Offset: 0x00058378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518258, RefRangeEnd = 518259, XrefRangeStart = 518253, XrefRangeEnd = 518258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOfflineMatchesManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOfflineMatchesManager<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOfflineMatchesManager<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public GenericOfflineMatchesManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0005A1B4 File Offset: 0x000583B4
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000ADA9 File Offset: 0x00008FA9
		public unsafe List<OfflineMatches<T>> allOfflineMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOfflineMatchesManager<T>.NativeFieldInfoPtr_allOfflineMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OfflineMatches<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOfflineMatchesManager<T>.NativeFieldInfoPtr_allOfflineMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_allOfflineMatches;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchInitData_Public_Virtual_MatchInitData_String_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Virtual_IEnumerable_1_MatchInitData_String_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_MatchInitData_SaveMetaData_SaveData_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_loadMatches_Protected_Virtual_Void_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
