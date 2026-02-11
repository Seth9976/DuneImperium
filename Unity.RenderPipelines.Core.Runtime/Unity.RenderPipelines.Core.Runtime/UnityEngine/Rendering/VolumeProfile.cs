using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000117 RID: 279
	public sealed class VolumeProfile : ScriptableObject
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00052660 File Offset: 0x00050860
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeProfile()
		{
			Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr);
			VolumeProfile.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, "components");
			VolumeProfile.NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, "isDirty");
			VolumeProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665953);
			VolumeProfile.NativeMethodInfoPtr_OnDisable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665954);
			VolumeProfile.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665955);
			VolumeProfile.NativeMethodInfoPtr_Add_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665956);
			VolumeProfile.NativeMethodInfoPtr_Add_Public_VolumeComponent_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665957);
			VolumeProfile.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665958);
			VolumeProfile.NativeMethodInfoPtr_Remove_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665959);
			VolumeProfile.NativeMethodInfoPtr_Has_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665960);
			VolumeProfile.NativeMethodInfoPtr_Has_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665961);
			VolumeProfile.NativeMethodInfoPtr_HasSubclassOf_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665962);
			VolumeProfile.NativeMethodInfoPtr_TryGet_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665963);
			VolumeProfile.NativeMethodInfoPtr_TryGet_Public_Boolean_Type_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665964);
			VolumeProfile.NativeMethodInfoPtr_TryGetSubclassOf_Public_Boolean_Type_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665965);
			VolumeProfile.NativeMethodInfoPtr_TryGetAllSubclassOf_Public_Boolean_Type_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665966);
			VolumeProfile.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665967);
			VolumeProfile.NativeMethodInfoPtr_GetComponentListHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665968);
			VolumeProfile.NativeMethodInfoPtr_Sanitize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665969);
			VolumeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, 100665970);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00052820 File Offset: 0x00050A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979323, XrefRangeEnd = 979342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00052854 File Offset: 0x00050A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979342, XrefRangeEnd = 979354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_OnDisable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00052888 File Offset: 0x00050A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497605, RefRangeEnd = 497606, XrefRangeStart = 497605, XrefRangeEnd = 497606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000528BC File Offset: 0x00050ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979354, XrefRangeEnd = 979361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Add<T>(bool overrides = false) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overrides;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_Add_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00052904 File Offset: 0x00050B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 979369, RefRangeEnd = 979370, XrefRangeStart = 979361, XrefRangeEnd = 979369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponent Add(Type type, bool overrides = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_Add_Public_VolumeComponent_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeComponent>(intPtr3) : null;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00052964 File Offset: 0x00050B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979370, XrefRangeEnd = 979376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove<T>() where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_Remove_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00052998 File Offset: 0x00050B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 979389, RefRangeEnd = 979390, XrefRangeStart = 979376, XrefRangeEnd = 979389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_Remove_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000529DC File Offset: 0x00050BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979390, XrefRangeEnd = 979396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Has<T>() where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_Has_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00052A18 File Offset: 0x00050C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 979411, RefRangeEnd = 979413, XrefRangeStart = 979396, XrefRangeEnd = 979411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Has(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_Has_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00052A68 File Offset: 0x00050C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979413, XrefRangeEnd = 979424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSubclassOf(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_HasSubclassOf_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00052AB8 File Offset: 0x00050CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979424, XrefRangeEnd = 979430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet<T>(out T component) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref component;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_TryGet_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00052B44 File Offset: 0x00050D44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979452, RefRangeEnd = 979456, XrefRangeStart = 979430, XrefRangeEnd = 979452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet<T>(Type type, out T component) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref component;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_TryGet_Public_Boolean_Type_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00052BE0 File Offset: 0x00050DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979456, XrefRangeEnd = 979474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref component;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_TryGetSubclassOf_Public_Boolean_Type_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00052C7C File Offset: 0x00050E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979474, XrefRangeEnd = 979494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.MethodInfoStoreGeneric_TryGetAllSubclassOf_Public_Boolean_Type_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00052CDC File Offset: 0x00050EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979494, XrefRangeEnd = 979499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00052D18 File Offset: 0x00050F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979499, XrefRangeEnd = 979505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComponentListHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_GetComponentListHashCode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00052D54 File Offset: 0x00050F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979505, XrefRangeEnd = 979516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sanitize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr_Sanitize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00052D88 File Offset: 0x00050F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979516, XrefRangeEnd = 979524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0000956E File Offset: 0x0000776E
		public VolumeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00052DC4 File Offset: 0x00050FC4
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00009577 File Offset: 0x00007777
		public unsafe List<VolumeComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeProfile.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeProfile.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00052DF4 File Offset: 0x00050FF4
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00009596 File Offset: 0x00007796
		public unsafe bool isDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeProfile.NativeFieldInfoPtr_isDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeProfile.NativeFieldInfoPtr_isDirty)) = value;
			}
		}

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_isDirty;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Void_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_T_Boolean_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_VolumeComponent_Type_Boolean_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Type_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Boolean_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Boolean_Type_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_HasSubclassOf_Public_Boolean_Type_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_byref_T_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_Type_byref_T_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSubclassOf_Public_Boolean_Type_byref_T_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAllSubclassOf_Public_Boolean_Type_List_1_T_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentListHashCode_Internal_Int32_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_Sanitize_Internal_Void_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("UnityEngine.Rendering.VolumeProfile+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B21 RID: 6945 RVA: 0x0006EF78 File Offset: 0x0006D178
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr);
				VolumeProfile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr, "<>9");
				VolumeProfile.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr, "<>9__2_0");
				VolumeProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr, 100665972);
				VolumeProfile.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_VolumeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr, 100665973);
			}

			// Token: 0x06001B22 RID: 6946 RVA: 0x0006EFF4 File Offset: 0x0006D1F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeProfile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B23 RID: 6947 RVA: 0x0006F030 File Offset: 0x0006D230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979319, XrefRangeEnd = 979323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__2_0(VolumeComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeProfile.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_VolumeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B24 RID: 6948 RVA: 0x0000D926 File Offset: 0x0000BB26
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0006F080 File Offset: 0x0006D280
			// (set) Token: 0x06001B26 RID: 6950 RVA: 0x0000D92F File Offset: 0x0000BB2F
			public unsafe static VolumeProfile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeProfile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeProfile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
			// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0000D941 File Offset: 0x0000BB41
			public unsafe static Predicate<VolumeComponent> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeProfile.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<VolumeComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeProfile.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040013C9 RID: 5065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013CA RID: 5066
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_VolumeComponent_0;
		}

		// Token: 0x0200020E RID: 526
		private sealed class MethodInfoStoreGeneric_Add_Public_T_Boolean_0<T>
		{
			// Token: 0x040013CB RID: 5067
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_Add_Public_T_Boolean_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200020F RID: 527
		private sealed class MethodInfoStoreGeneric_Remove_Public_Void_0<T>
		{
			// Token: 0x040013CC RID: 5068
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_Remove_Public_Void_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000210 RID: 528
		private sealed class MethodInfoStoreGeneric_Has_Public_Boolean_0<T>
		{
			// Token: 0x040013CD RID: 5069
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_Has_Public_Boolean_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000211 RID: 529
		private sealed class MethodInfoStoreGeneric_TryGet_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x040013CE RID: 5070
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_TryGet_Public_Boolean_byref_T_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000212 RID: 530
		private sealed class MethodInfoStoreGeneric_TryGet_Public_Boolean_Type_byref_T_0<T>
		{
			// Token: 0x040013CF RID: 5071
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_TryGet_Public_Boolean_Type_byref_T_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000213 RID: 531
		private sealed class MethodInfoStoreGeneric_TryGetSubclassOf_Public_Boolean_Type_byref_T_0<T>
		{
			// Token: 0x040013D0 RID: 5072
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_TryGetSubclassOf_Public_Boolean_Type_byref_T_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000214 RID: 532
		private sealed class MethodInfoStoreGeneric_TryGetAllSubclassOf_Public_Boolean_Type_List_1_T_0<T>
		{
			// Token: 0x040013D1 RID: 5073
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeProfile.NativeMethodInfoPtr_TryGetAllSubclassOf_Public_Boolean_Type_List_1_T_0, Il2CppClassPointerStore<VolumeProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
