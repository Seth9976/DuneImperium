using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class RegisteredComponent : MonoBehaviour
{
	// Token: 0x0600028C RID: 652 RVA: 0x0001CA00 File Offset: 0x0001AC00
	// Note: this type is marked as 'beforefieldinit'.
	static RegisteredComponent()
	{
		Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "RegisteredComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr);
		RegisteredComponent.NativeFieldInfoPtr_isRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, "isRegistered");
		RegisteredComponent.NativeFieldInfoPtr_isUnregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, "isUnregistered");
		RegisteredComponent.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, 100663642);
		RegisteredComponent.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, 100663643);
		RegisteredComponent.NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, 100663644);
		RegisteredComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr, 100663645);
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853380, XrefRangeEnd = 853392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisteredComponent.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853402, RefRangeEnd = 853403, XrefRangeStart = 853392, XrefRangeEnd = 853402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisteredComponent.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0001CB20 File Offset: 0x0001AD20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853403, XrefRangeEnd = 853409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Type GetRegisteredComponentBaseClassType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponent.NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0001CB60 File Offset: 0x0001AD60
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegisteredComponent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredComponent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000317A File Offset: 0x0000137A
	public RegisteredComponent(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000292 RID: 658 RVA: 0x0001CB9C File Offset: 0x0001AD9C
	// (set) Token: 0x06000293 RID: 659 RVA: 0x00003183 File Offset: 0x00001383
	public unsafe bool isRegistered
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredComponent.NativeFieldInfoPtr_isRegistered);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredComponent.NativeFieldInfoPtr_isRegistered)) = value;
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000294 RID: 660 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
	// (set) Token: 0x06000295 RID: 661 RVA: 0x0000319E File Offset: 0x0000139E
	public unsafe bool isUnregistered
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredComponent.NativeFieldInfoPtr_isUnregistered);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredComponent.NativeFieldInfoPtr_isUnregistered)) = value;
		}
	}

	// Token: 0x040001E0 RID: 480
	private static readonly IntPtr NativeFieldInfoPtr_isRegistered;

	// Token: 0x040001E1 RID: 481
	private static readonly IntPtr NativeFieldInfoPtr_isUnregistered;

	// Token: 0x040001E2 RID: 482
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	// Token: 0x040001E3 RID: 483
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

	// Token: 0x040001E4 RID: 484
	private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Virtual_Final_New_Type_0;

	// Token: 0x040001E5 RID: 485
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
