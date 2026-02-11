using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000002 RID: 2
	public sealed class VFXEventAttribute : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000317C File Offset: 0x0000137C
		// Note: this type is marked as 'beforefieldinit'.
		static VFXEventAttribute()
		{
			Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXEventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr);
			VFXEventAttribute.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_Ptr");
			VFXEventAttribute.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_Owner");
			VFXEventAttribute.NativeFieldInfoPtr_m_VfxAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_VfxAsset");
			VFXEventAttribute.NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663297);
			VFXEventAttribute.NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663298);
			VFXEventAttribute.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663299);
			VFXEventAttribute.NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663300);
			VFXEventAttribute.NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663301);
			VFXEventAttribute.NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663302);
			VFXEventAttribute.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663303);
			VFXEventAttribute.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663304);
			VFXEventAttribute.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663305);
			VFXEventAttribute.NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663306);
			VFXEventAttribute.Internal_InitFromEventAttributeDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.Internal_InitFromEventAttributeDelegate>("UnityEngine.VFX.VFXEventAttribute::Internal_InitFromEventAttribute");
			VFXEventAttribute.HasBoolDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasBoolDelegate>("UnityEngine.VFX.VFXEventAttribute::HasBool");
			VFXEventAttribute.HasIntDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasIntDelegate>("UnityEngine.VFX.VFXEventAttribute::HasInt");
			VFXEventAttribute.HasUintDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasUintDelegate>("UnityEngine.VFX.VFXEventAttribute::HasUint");
			VFXEventAttribute.HasFloatDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasFloatDelegate>("UnityEngine.VFX.VFXEventAttribute::HasFloat");
			VFXEventAttribute.HasVector2DelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasVector2Delegate>("UnityEngine.VFX.VFXEventAttribute::HasVector2");
			VFXEventAttribute.HasVector3DelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasVector3Delegate>("UnityEngine.VFX.VFXEventAttribute::HasVector3");
			VFXEventAttribute.HasVector4DelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasVector4Delegate>("UnityEngine.VFX.VFXEventAttribute::HasVector4");
			VFXEventAttribute.HasMatrix4x4DelegateField = IL2CPP.ResolveICall<VFXEventAttribute.HasMatrix4x4Delegate>("UnityEngine.VFX.VFXEventAttribute::HasMatrix4x4");
			VFXEventAttribute.SetBoolDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetBoolDelegate>("UnityEngine.VFX.VFXEventAttribute::SetBool");
			VFXEventAttribute.SetIntDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetIntDelegate>("UnityEngine.VFX.VFXEventAttribute::SetInt");
			VFXEventAttribute.SetUintDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetUintDelegate>("UnityEngine.VFX.VFXEventAttribute::SetUint");
			VFXEventAttribute.SetFloatDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetFloatDelegate>("UnityEngine.VFX.VFXEventAttribute::SetFloat");
			VFXEventAttribute.GetBoolDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetBoolDelegate>("UnityEngine.VFX.VFXEventAttribute::GetBool");
			VFXEventAttribute.GetIntDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetIntDelegate>("UnityEngine.VFX.VFXEventAttribute::GetInt");
			VFXEventAttribute.GetUintDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetUintDelegate>("UnityEngine.VFX.VFXEventAttribute::GetUint");
			VFXEventAttribute.GetFloatDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetFloatDelegate>("UnityEngine.VFX.VFXEventAttribute::GetFloat");
			VFXEventAttribute.CopyValuesFromDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.CopyValuesFromDelegate>("UnityEngine.VFX.VFXEventAttribute::CopyValuesFrom");
			VFXEventAttribute.SetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetVector2_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::SetVector2_Injected");
			VFXEventAttribute.SetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetVector3_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::SetVector3_Injected");
			VFXEventAttribute.SetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetVector4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::SetVector4_Injected");
			VFXEventAttribute.SetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.SetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::SetMatrix4x4_Injected");
			VFXEventAttribute.GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetVector2_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector2_Injected");
			VFXEventAttribute.GetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetVector3_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector3_Injected");
			VFXEventAttribute.GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetVector4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector4_Injected");
			VFXEventAttribute.GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VFXEventAttribute.GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetMatrix4x4_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003438 File Offset: 0x00001638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269700, XrefRangeEnd = 1269702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref owner;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000034A0 File Offset: 0x000016A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269702, XrefRangeEnd = 1269707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXEventAttribute CreateEventAttributeWrapper()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000034D4 File Offset: 0x000016D4
		[CallerCount(0)]
		public unsafe void SetWrapValue(IntPtr ptrToEventAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ptrToEventAttribute;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00003514 File Offset: 0x00001714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269707, XrefRangeEnd = 1269709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003544 File Offset: 0x00001744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269709, XrefRangeEnd = 1269718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfxAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003588 File Offset: 0x00001788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269718, XrefRangeEnd = 1269720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_InitFromAsset(VisualEffectAsset vfxAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfxAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000035CC File Offset: 0x000017CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269720, XrefRangeEnd = 1269724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003600 File Offset: 0x00001800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269724, XrefRangeEnd = 1269731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003634 File Offset: 0x00001834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269731, XrefRangeEnd = 1269739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003668 File Offset: 0x00001868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269739, XrefRangeEnd = 1269741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXEventAttribute.NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		public VFXEventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000369C File Offset: 0x0000189C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe bool m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_Owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_Owner)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000036EC File Offset: 0x000018EC
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe VisualEffectAsset m_VfxAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_VfxAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXEventAttribute.NativeFieldInfoPtr_m_VfxAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020AE File Offset: 0x000002AE
		public void Internal_InitFromEventAttribute(VFXEventAttribute vfxEventAttribute)
		{
			VFXEventAttribute.Internal_InitFromEventAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vfxEventAttribute));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000371C File Offset: 0x0000191C
		public VisualEffectAsset vfxAsset
		{
			get
			{
				return this.m_VfxAsset;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020C6 File Offset: 0x000002C6
		public bool HasBool(int nameID)
		{
			return VFXEventAttribute.HasBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020D9 File Offset: 0x000002D9
		public bool HasInt(int nameID)
		{
			return VFXEventAttribute.HasIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020EC File Offset: 0x000002EC
		public bool HasUint(int nameID)
		{
			return VFXEventAttribute.HasUintDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020FF File Offset: 0x000002FF
		public bool HasFloat(int nameID)
		{
			return VFXEventAttribute.HasFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002112 File Offset: 0x00000312
		public bool HasVector2(int nameID)
		{
			return VFXEventAttribute.HasVector2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002125 File Offset: 0x00000325
		public bool HasVector3(int nameID)
		{
			return VFXEventAttribute.HasVector3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002138 File Offset: 0x00000338
		public bool HasVector4(int nameID)
		{
			return VFXEventAttribute.HasVector4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000214B File Offset: 0x0000034B
		public bool HasMatrix4x4(int nameID)
		{
			return VFXEventAttribute.HasMatrix4x4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000215E File Offset: 0x0000035E
		public void SetBool(int nameID, bool b)
		{
			VFXEventAttribute.SetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, b);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002172 File Offset: 0x00000372
		public void SetInt(int nameID, int i)
		{
			VFXEventAttribute.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002186 File Offset: 0x00000386
		public void SetUint(int nameID, uint i)
		{
			VFXEventAttribute.SetUintDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000219A File Offset: 0x0000039A
		public void SetFloat(int nameID, float f)
		{
			VFXEventAttribute.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, f);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021AE File Offset: 0x000003AE
		public void SetVector2(int nameID, Vector2 v)
		{
			this.SetVector2_Injected(nameID, ref v);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021B9 File Offset: 0x000003B9
		public void SetVector3(int nameID, Vector3 v)
		{
			this.SetVector3_Injected(nameID, ref v);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021C4 File Offset: 0x000003C4
		public void SetVector4(int nameID, Vector4 v)
		{
			this.SetVector4_Injected(nameID, ref v);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021CF File Offset: 0x000003CF
		public void SetMatrix4x4(int nameID, Matrix4x4 v)
		{
			this.SetMatrix4x4_Injected(nameID, ref v);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021DA File Offset: 0x000003DA
		public bool GetBool(int nameID)
		{
			return VFXEventAttribute.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021ED File Offset: 0x000003ED
		public int GetInt(int nameID)
		{
			return VFXEventAttribute.GetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002200 File Offset: 0x00000400
		public uint GetUint(int nameID)
		{
			return VFXEventAttribute.GetUintDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002213 File Offset: 0x00000413
		public float GetFloat(int nameID)
		{
			return VFXEventAttribute.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003734 File Offset: 0x00001934
		public Vector2 GetVector2(int nameID)
		{
			Vector2 vector;
			this.GetVector2_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000374C File Offset: 0x0000194C
		public Vector3 GetVector3(int nameID)
		{
			Vector3 vector;
			this.GetVector3_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003764 File Offset: 0x00001964
		public Vector4 GetVector4(int nameID)
		{
			Vector4 vector;
			this.GetVector4_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000377C File Offset: 0x0000197C
		public Matrix4x4 GetMatrix4x4(int nameID)
		{
			Matrix4x4 matrix4x;
			this.GetMatrix4x4_Injected(nameID, out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003794 File Offset: 0x00001994
		public bool HasBool(string name)
		{
			return this.HasBool(Shader.PropertyToID(name));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000037B4 File Offset: 0x000019B4
		public bool HasInt(string name)
		{
			return this.HasInt(Shader.PropertyToID(name));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000037D4 File Offset: 0x000019D4
		public bool HasUint(string name)
		{
			return this.HasUint(Shader.PropertyToID(name));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000037F4 File Offset: 0x000019F4
		public bool HasFloat(string name)
		{
			return this.HasFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003814 File Offset: 0x00001A14
		public bool HasVector2(string name)
		{
			return this.HasVector2(Shader.PropertyToID(name));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003834 File Offset: 0x00001A34
		public bool HasVector3(string name)
		{
			return this.HasVector3(Shader.PropertyToID(name));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003854 File Offset: 0x00001A54
		public bool HasVector4(string name)
		{
			return this.HasVector4(Shader.PropertyToID(name));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003874 File Offset: 0x00001A74
		public bool HasMatrix4x4(string name)
		{
			return this.HasMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002226 File Offset: 0x00000426
		public void SetBool(string name, bool b)
		{
			this.SetBool(Shader.PropertyToID(name), b);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002237 File Offset: 0x00000437
		public void SetInt(string name, int i)
		{
			this.SetInt(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002248 File Offset: 0x00000448
		public void SetUint(string name, uint i)
		{
			this.SetUint(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002259 File Offset: 0x00000459
		public void SetFloat(string name, float f)
		{
			this.SetFloat(Shader.PropertyToID(name), f);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000226A File Offset: 0x0000046A
		public void SetVector2(string name, Vector2 v)
		{
			this.SetVector2(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000227B File Offset: 0x0000047B
		public void SetVector3(string name, Vector3 v)
		{
			this.SetVector3(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000228C File Offset: 0x0000048C
		public void SetVector4(string name, Vector4 v)
		{
			this.SetVector4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000229D File Offset: 0x0000049D
		public void SetMatrix4x4(string name, Matrix4x4 v)
		{
			this.SetMatrix4x4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003894 File Offset: 0x00001A94
		public bool GetBool(string name)
		{
			return this.GetBool(Shader.PropertyToID(name));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000038B4 File Offset: 0x00001AB4
		public int GetInt(string name)
		{
			return this.GetInt(Shader.PropertyToID(name));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000038D4 File Offset: 0x00001AD4
		public uint GetUint(string name)
		{
			return this.GetUint(Shader.PropertyToID(name));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000038F4 File Offset: 0x00001AF4
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003914 File Offset: 0x00001B14
		public Vector2 GetVector2(string name)
		{
			return this.GetVector2(Shader.PropertyToID(name));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003934 File Offset: 0x00001B34
		public Vector3 GetVector3(string name)
		{
			return this.GetVector3(Shader.PropertyToID(name));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003954 File Offset: 0x00001B54
		public Vector4 GetVector4(string name)
		{
			return this.GetVector4(Shader.PropertyToID(name));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003974 File Offset: 0x00001B74
		public Matrix4x4 GetMatrix4x4(string name)
		{
			return this.GetMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000022AE File Offset: 0x000004AE
		public void CopyValuesFrom(VFXEventAttribute eventAttibute)
		{
			VFXEventAttribute.CopyValuesFromDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(eventAttibute));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022C6 File Offset: 0x000004C6
		public void SetVector2_Injected(int nameID, ref Vector2 v)
		{
			VFXEventAttribute.SetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022DA File Offset: 0x000004DA
		public void SetVector3_Injected(int nameID, ref Vector3 v)
		{
			VFXEventAttribute.SetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022EE File Offset: 0x000004EE
		public void SetVector4_Injected(int nameID, ref Vector4 v)
		{
			VFXEventAttribute.SetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002302 File Offset: 0x00000502
		public void SetMatrix4x4_Injected(int nameID, ref Matrix4x4 v)
		{
			VFXEventAttribute.SetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002316 File Offset: 0x00000516
		public void GetVector2_Injected(int nameID, out Vector2 ret)
		{
			VFXEventAttribute.GetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000232A File Offset: 0x0000052A
		public void GetVector3_Injected(int nameID, out Vector3 ret)
		{
			VFXEventAttribute.GetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000233E File Offset: 0x0000053E
		public void GetVector4_Injected(int nameID, out Vector4 ret)
		{
			VFXEventAttribute.GetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002352 File Offset: 0x00000552
		public void GetMatrix4x4_Injected(int nameID, out Matrix4x4 ret)
		{
			VFXEventAttribute.GetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_VfxAsset;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400000E RID: 14
		private static readonly VFXEventAttribute.Internal_InitFromEventAttributeDelegate Internal_InitFromEventAttributeDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly VFXEventAttribute.HasBoolDelegate HasBoolDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly VFXEventAttribute.HasIntDelegate HasIntDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly VFXEventAttribute.HasUintDelegate HasUintDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly VFXEventAttribute.HasFloatDelegate HasFloatDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly VFXEventAttribute.HasVector2Delegate HasVector2DelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly VFXEventAttribute.HasVector3Delegate HasVector3DelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly VFXEventAttribute.HasVector4Delegate HasVector4DelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly VFXEventAttribute.HasMatrix4x4Delegate HasMatrix4x4DelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly VFXEventAttribute.SetBoolDelegate SetBoolDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly VFXEventAttribute.SetIntDelegate SetIntDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly VFXEventAttribute.SetUintDelegate SetUintDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly VFXEventAttribute.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly VFXEventAttribute.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly VFXEventAttribute.GetIntDelegate GetIntDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly VFXEventAttribute.GetUintDelegate GetUintDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly VFXEventAttribute.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly VFXEventAttribute.CopyValuesFromDelegate CopyValuesFromDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly VFXEventAttribute.SetVector2_InjectedDelegate SetVector2_InjectedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly VFXEventAttribute.SetVector3_InjectedDelegate SetVector3_InjectedDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly VFXEventAttribute.SetVector4_InjectedDelegate SetVector4_InjectedDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly VFXEventAttribute.SetMatrix4x4_InjectedDelegate SetMatrix4x4_InjectedDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly VFXEventAttribute.GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly VFXEventAttribute.GetVector3_InjectedDelegate GetVector3_InjectedDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly VFXEventAttribute.GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly VFXEventAttribute.GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000197 RID: 407
		private delegate void Internal_InitFromEventAttributeDelegate(IntPtr @this, IntPtr vfxEventAttribute);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000199 RID: 409
		private delegate bool HasBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600019B RID: 411
		private delegate bool HasIntDelegate(IntPtr @this, int nameID);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600019D RID: 413
		private delegate bool HasUintDelegate(IntPtr @this, int nameID);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600019F RID: 415
		private delegate bool HasFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060001A1 RID: 417
		private delegate bool HasVector2Delegate(IntPtr @this, int nameID);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060001A3 RID: 419
		private delegate bool HasVector3Delegate(IntPtr @this, int nameID);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060001A5 RID: 421
		private delegate bool HasVector4Delegate(IntPtr @this, int nameID);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060001A7 RID: 423
		private delegate bool HasMatrix4x4Delegate(IntPtr @this, int nameID);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060001A9 RID: 425
		private delegate void SetBoolDelegate(IntPtr @this, int nameID, bool b);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060001AB RID: 427
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int i);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060001AD RID: 429
		private delegate void SetUintDelegate(IntPtr @this, int nameID, uint i);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060001AF RID: 431
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float f);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060001B1 RID: 433
		private delegate bool GetBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060001B3 RID: 435
		private delegate int GetIntDelegate(IntPtr @this, int nameID);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060001B5 RID: 437
		private delegate uint GetUintDelegate(IntPtr @this, int nameID);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060001B7 RID: 439
		private delegate float GetFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001B9 RID: 441
		private delegate void CopyValuesFromDelegate(IntPtr @this, IntPtr eventAttibute);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001BB RID: 443
		private delegate void SetVector2_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001BD RID: 445
		private delegate void SetVector3_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001BF RID: 447
		private delegate void SetVector4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001C1 RID: 449
		private delegate void SetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001C3 RID: 451
		private delegate void GetVector2_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001C5 RID: 453
		private delegate void GetVector3_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001C7 RID: 455
		private delegate void GetVector4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001C9 RID: 457
		private delegate void GetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);
	}
}
