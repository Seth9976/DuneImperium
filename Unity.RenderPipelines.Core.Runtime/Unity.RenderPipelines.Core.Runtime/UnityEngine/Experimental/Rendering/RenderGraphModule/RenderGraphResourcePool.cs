using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000024 RID: 36
	public class RenderGraphResourcePool<Type> : IRenderGraphResourcePool where Type : class
	{
		// Token: 0x06000324 RID: 804 RVA: 0x00018FF0 File Offset: 0x000171F0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphResourcePool()
		{
			Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphResourcePool`1"))).MakeGenericType(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr);
			RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_ResourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "m_ResourcePool");
			RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_RemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "m_RemoveList");
			RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_FrameAllocatedResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "m_FrameAllocatedResources");
			RenderGraphResourcePool<Type>.NativeFieldInfoPtr_s_CurrentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "s_CurrentFrameIndex");
			RenderGraphResourcePool<Type>.NativeFieldInfoPtr_kStaleResourceLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "kStaleResourceLifetime");
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Abstract_Virtual_New_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663684);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceName_Protected_Abstract_Virtual_New_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663685);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceSize_Protected_Abstract_Virtual_New_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663686);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceTypeName_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663687);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetSortIndex_Protected_Abstract_Virtual_New_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663688);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ReleaseResource_Public_Void_Int32_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663689);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_TryGetResource_Public_Boolean_Int32_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663690);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663691);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_RegisterFrameAllocation_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663692);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_UnregisterFrameAllocation_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663693);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_CheckFrameAllocation_Public_Virtual_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663694);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_LogResources_Public_Virtual_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663695);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663696);
			RenderGraphResourcePool<Type>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, 100663697);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000191D8 File Offset: 0x000173D8
		[CallerCount(0)]
		public unsafe virtual void ReleaseInternalResource(Type res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(Type).IsValueType)
				{
					Type type = res;
					intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref res;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ReleaseInternalResource_Protected_Abstract_Virtual_New_Void_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001925C File Offset: 0x0001745C
		[CallerCount(0)]
		public unsafe virtual string GetResourceName(Type res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(Type).IsValueType)
				{
					Type type = res;
					intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref res;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceName_Protected_Abstract_Virtual_New_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000192E8 File Offset: 0x000174E8
		[CallerCount(0)]
		public unsafe virtual long GetResourceSize(Type res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(Type).IsValueType)
				{
					Type type = res;
					intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref res;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceSize_Protected_Abstract_Virtual_New_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00019378 File Offset: 0x00017578
		[CallerCount(0)]
		public unsafe virtual string GetResourceTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetResourceTypeName_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000193BC File Offset: 0x000175BC
		[CallerCount(0)]
		public unsafe virtual int GetSortIndex(Type res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(Type).IsValueType)
				{
					Type type = res;
					intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref res;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_GetSortIndex_Protected_Abstract_Virtual_New_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001944C File Offset: 0x0001764C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957528, RefRangeEnd = 957530, XrefRangeStart = 957521, XrefRangeEnd = 957528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseResource(int hash, Type resource, int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(Type).IsValueType)
			{
				Type type = resource;
				intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref resource;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFrameIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ReleaseResource_Public_Void_Int32_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000194E0 File Offset: 0x000176E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957536, RefRangeEnd = 957538, XrefRangeStart = 957530, XrefRangeEnd = 957536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetResource(int hashCode, out Type resource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(Type).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref resource;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr_TryGetResource_Public_Boolean_Int32_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(Type).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				resource = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<Type>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00019578 File Offset: 0x00017778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957538, XrefRangeEnd = 957557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000195B4 File Offset: 0x000177B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957559, RefRangeEnd = 957561, XrefRangeStart = 957557, XrefRangeEnd = 957559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFrameAllocation(int hash, Type value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(Type).IsValueType)
			{
				Type type = value;
				intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr_RegisterFrameAllocation_Public_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001963C File Offset: 0x0001783C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957563, RefRangeEnd = 957565, XrefRangeStart = 957561, XrefRangeEnd = 957563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterFrameAllocation(int hash, Type value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(Type).IsValueType)
			{
				Type type = value;
				intPtr = ((type is string) ? IL2CPP.ManagedStringToIl2Cpp(type as string) : IL2CPP.Il2CppObjectBaseToPtr(type as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr_UnregisterFrameAllocation_Public_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000196C4 File Offset: 0x000178C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957565, XrefRangeEnd = 957587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CheckFrameAllocation(bool onException, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onException;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_CheckFrameAllocation_Public_Virtual_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001971C File Offset: 0x0001791C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957587, XrefRangeEnd = 957663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogResources(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResourcePool<Type>.NativeMethodInfoPtr_LogResources_Public_Virtual_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001976C File Offset: 0x0001796C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957663, RefRangeEnd = 957665, XrefRangeStart = 957663, XrefRangeEnd = 957663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastUsedFrameIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFrameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000197B8 File Offset: 0x000179B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 957682, RefRangeEnd = 957685, XrefRangeStart = 957665, XrefRangeEnd = 957682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphResourcePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000034E1 File Offset: 0x000016E1
		public RenderGraphResourcePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000197F4 File Offset: 0x000179F4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000034EA File Offset: 0x000016EA
		public unsafe Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_ResourcePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SortedList<int, ValueTuple<Type, int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_ResourcePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00019824 File Offset: 0x00017A24
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003509 File Offset: 0x00001709
		public unsafe List<int> m_RemoveList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_RemoveList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_RemoveList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00019854 File Offset: 0x00017A54
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003528 File Offset: 0x00001728
		public unsafe List<ValueTuple<int, Type>> m_FrameAllocatedResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_FrameAllocatedResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, Type>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_m_FrameAllocatedResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00019884 File Offset: 0x00017A84
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003547 File Offset: 0x00001747
		public unsafe static int s_CurrentFrameIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_s_CurrentFrameIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_s_CurrentFrameIndex, (void*)(&value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000198A0 File Offset: 0x00017AA0
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003555 File Offset: 0x00001755
		public unsafe static int kStaleResourceLifetime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_kStaleResourceLifetime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraphResourcePool<Type>.NativeFieldInfoPtr_kStaleResourceLifetime, (void*)(&value));
			}
		}

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourcePool;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveList;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameAllocatedResources;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentFrameIndex;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_kStaleResourceLifetime;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternalResource_Protected_Abstract_Virtual_New_Void_Type_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Protected_Abstract_Virtual_New_String_Type_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSize_Protected_Abstract_Virtual_New_Int64_Type_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceTypeName_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Protected_Abstract_Virtual_New_Int32_Type_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseResource_Public_Void_Int32_Type_Int32_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_TryGetResource_Public_Boolean_Int32_byref_Type_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFrameAllocation_Public_Void_Int32_Type_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterFrameAllocation_Public_Void_Int32_Type_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_CheckFrameAllocation_Public_Virtual_Void_Boolean_Int32_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_LogResources_Public_Virtual_Void_RenderGraphLogger_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000157 RID: 343
		public sealed class ResourceLogInfo : ValueType
		{
			// Token: 0x060015B7 RID: 5559 RVA: 0x0005E6B4 File Offset: 0x0005C8B4
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceLogInfo()
			{
				Il2CppClassPointerStore<RenderGraphResourcePool<Type>.ResourceLogInfo>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "ResourceLogInfo"))).MakeGenericType(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.ResourceLogInfo>.NativeClassPtr);
				RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.ResourceLogInfo>.NativeClassPtr, "name");
				RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.ResourceLogInfo>.NativeClassPtr, "size");
			}

			// Token: 0x060015B8 RID: 5560 RVA: 0x0000AFEF File Offset: 0x000091EF
			public ResourceLogInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060015B9 RID: 5561 RVA: 0x0000AFF8 File Offset: 0x000091F8
			public ResourceLogInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.ResourceLogInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x060015BA RID: 5562 RVA: 0x0005E744 File Offset: 0x0005C944
			// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000B00A File Offset: 0x0000920A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x060015BC RID: 5564 RVA: 0x0005E76C File Offset: 0x0005C96C
			// (set) Token: 0x060015BD RID: 5565 RVA: 0x0000B029 File Offset: 0x00009229
			public unsafe long size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourcePool<Type>.ResourceLogInfo.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x04000FDA RID: 4058
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000FDB RID: 4059
			private static readonly IntPtr NativeFieldInfoPtr_size;
		}

		// Token: 0x02000158 RID: 344
		[ObfuscatedName("UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060015BE RID: 5566 RVA: 0x0005E794 File Offset: 0x0005C994
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourcePool<Type>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr);
				RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr, "<>9");
				RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr, "<>9__17_0");
				RenderGraphResourcePool<Type>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr, 100663699);
				RenderGraphResourcePool<Type>.__c.NativeMethodInfoPtr__LogResources_b__17_0_Internal_Int32_ResourceLogInfo_Type_ResourceLogInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr, 100663700);
			}

			// Token: 0x060015BF RID: 5567 RVA: 0x0005E84C File Offset: 0x0005CA4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourcePool<Type>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015C0 RID: 5568 RVA: 0x0005E888 File Offset: 0x0005CA88
			[CallerCount(0)]
			public unsafe int _LogResources_b__17_0(RenderGraphResourcePool<Type>.ResourceLogInfo a, RenderGraphResourcePool<Type>.ResourceLogInfo b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourcePool<Type>.__c.NativeMethodInfoPtr__LogResources_b__17_0_Internal_Int32_ResourceLogInfo_Type_ResourceLogInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015C1 RID: 5569 RVA: 0x0000B044 File Offset: 0x00009244
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0005E8F4 File Offset: 0x0005CAF4
			// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0000B04D File Offset: 0x0000924D
			public unsafe static RenderGraphResourcePool<Type>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourcePool<Type>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0005E91C File Offset: 0x0005CB1C
			// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0000B05F File Offset: 0x0000925F
			public unsafe static Comparison<RenderGraphResourcePool<Type>.ResourceLogInfo> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RenderGraphResourcePool<Type>.ResourceLogInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphResourcePool<Type>.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FDC RID: 4060
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FDD RID: 4061
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04000FDE RID: 4062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FDF RID: 4063
			private static readonly IntPtr NativeMethodInfoPtr__LogResources_b__17_0_Internal_Int32_ResourceLogInfo_Type_ResourceLogInfo_Type_0;
		}
	}
}
