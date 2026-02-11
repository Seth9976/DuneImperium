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
	// Token: 0x02000118 RID: 280
	public sealed class VolumeStack : Object
	{
		// Token: 0x0600123D RID: 4669 RVA: 0x00052E1C File Offset: 0x0005101C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeStack()
		{
			Il2CppClassPointerStore<VolumeStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr);
			VolumeStack.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, "components");
			VolumeStack.NativeFieldInfoPtr_defaultParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, "defaultParameters");
			VolumeStack.NativeFieldInfoPtr_requiresReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, "requiresReset");
			VolumeStack.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665974);
			VolumeStack.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665975);
			VolumeStack.NativeMethodInfoPtr_Reload_Internal_Void_List_1_VolumeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665976);
			VolumeStack.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665977);
			VolumeStack.NativeMethodInfoPtr_GetComponent_Public_VolumeComponent_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665978);
			VolumeStack.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr, 100665979);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00052F00 File Offset: 0x00051100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979524, XrefRangeEnd = 979532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00052F3C File Offset: 0x0005113C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 979556, RefRangeEnd = 979559, XrefRangeStart = 979532, XrefRangeEnd = 979556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00052F70 File Offset: 0x00051170
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979610, RefRangeEnd = 979614, XrefRangeStart = 979559, XrefRangeEnd = 979610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reload(List<VolumeComponent> componentDefaultStates)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentDefaultStates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.NativeMethodInfoPtr_Reload_Internal_Void_List_1_VolumeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00052FB4 File Offset: 0x000511B4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 979621, RefRangeEnd = 979645, XrefRangeStart = 979614, XrefRangeEnd = 979621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>() where T : VolumeComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00052FF0 File Offset: 0x000511F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 979648, RefRangeEnd = 979651, XrefRangeStart = 979645, XrefRangeEnd = 979648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponent GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.NativeMethodInfoPtr_GetComponent_Public_VolumeComponent_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00053040 File Offset: 0x00051240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979651, XrefRangeEnd = 979652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeStack.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x000095B1 File Offset: 0x000077B1
		public VolumeStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00053074 File Offset: 0x00051274
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x000095BA File Offset: 0x000077BA
		public unsafe Dictionary<Type, VolumeComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, VolumeComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000530A4 File Offset: 0x000512A4
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x000095D9 File Offset: 0x000077D9
		public unsafe Il2CppReferenceArray<ValueTuple<VolumeParameter, VolumeParameter>> defaultParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_defaultParameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<VolumeParameter, VolumeParameter>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_defaultParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000530D4 File Offset: 0x000512D4
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x000095F8 File Offset: 0x000077F8
		public unsafe bool requiresReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_requiresReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeStack.NativeFieldInfoPtr_requiresReset)) = value;
			}
		}

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_defaultParameters;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_requiresReset;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Internal_Void_List_1_VolumeComponent_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_VolumeComponent_Type_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000215 RID: 533
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x040013D2 RID: 5074
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeStack.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<VolumeStack>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
