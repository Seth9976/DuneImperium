using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EE RID: 238
	public class VolumeParameter : Object
	{
		// Token: 0x06001116 RID: 4374 RVA: 0x0004E328 File Offset: 0x0004C528
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeParameter()
		{
			Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr);
			VolumeParameter.NativeFieldInfoPtr_k_DebuggerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, "k_DebuggerDisplay");
			VolumeParameter.NativeFieldInfoPtr_m_OverrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, "m_OverrideState");
			VolumeParameter.NativeMethodInfoPtr_get_overrideState_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665824);
			VolumeParameter.NativeMethodInfoPtr_set_overrideState_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665825);
			VolumeParameter.NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_VolumeParameter_VolumeParameter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665826);
			VolumeParameter.NativeMethodInfoPtr_GetValue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665827);
			VolumeParameter.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_VolumeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665828);
			VolumeParameter.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665829);
			VolumeParameter.NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665830);
			VolumeParameter.NativeMethodInfoPtr_IsObjectParameter_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665831);
			VolumeParameter.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665832);
			VolumeParameter.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665833);
			VolumeParameter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr, 100665834);
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0004E45C File Offset: 0x0004C65C
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
		public unsafe virtual bool overrideState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_get_overrideState_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_set_overrideState_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0004E4F0 File Offset: 0x0004C6F0
		[CallerCount(0)]
		public unsafe virtual void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_VolumeParameter_VolumeParameter_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0004E560 File Offset: 0x0004C760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 978804, RefRangeEnd = 978806, XrefRangeStart = 978795, XrefRangeEnd = 978804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeParameter.MethodInfoStoreGeneric_GetValue_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0004E59C File Offset: 0x0004C79C
		[CallerCount(0)]
		public unsafe virtual void SetValue(VolumeParameter parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_VolumeParameter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0004E5EC File Offset: 0x0004C7EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0004E628 File Offset: 0x0004C828
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0004E664 File Offset: 0x0004C864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 978813, RefRangeEnd = 978814, XrefRangeStart = 978806, XrefRangeEnd = 978813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObjectParameter(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeParameter.NativeMethodInfoPtr_IsObjectParameter_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0004E6E4 File Offset: 0x0004C8E4
		[CallerCount(0)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumeParameter.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0004E730 File Offset: 0x0004C930
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeParameter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00008F2E File Offset: 0x0000712E
		public VolumeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0004E76C File Offset: 0x0004C96C
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x00008F37 File Offset: 0x00007137
		public unsafe static string k_DebuggerDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumeParameter.NativeFieldInfoPtr_k_DebuggerDisplay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeParameter.NativeFieldInfoPtr_k_DebuggerDisplay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0004E78C File Offset: 0x0004C98C
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00008F49 File Offset: 0x00007149
		public unsafe bool m_OverrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeParameter.NativeFieldInfoPtr_m_OverrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeParameter.NativeFieldInfoPtr_m_OverrideState)) = value;
			}
		}

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_k_DebuggerDisplay;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideState;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideState_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideState_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Internal_Abstract_Virtual_New_Void_VolumeParameter_VolumeParameter_Single_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_VolumeParameter_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_FamOrAssem_Virtual_New_Void_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_FamOrAssem_Virtual_New_Void_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectParameter_Public_Static_Boolean_Type_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200020A RID: 522
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_0<T>
		{
			// Token: 0x040013BD RID: 5053
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VolumeParameter.NativeMethodInfoPtr_GetValue_Public_T_0, Il2CppClassPointerStore<VolumeParameter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
