using System;
using Canis.utils.ids;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class FriendGameCreateResponder : Subscriber<IDComponent<AccountID>>
{
	// Token: 0x06000071 RID: 113 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
	// Note: this type is marked as 'beforefieldinit'.
	static FriendGameCreateResponder()
	{
		Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "FriendGameCreateResponder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr);
		FriendGameCreateResponder.NativeFieldInfoPtr_friendGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr, "friendGameButton");
		FriendGameCreateResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr, 100663379);
		FriendGameCreateResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr, 100663380);
		FriendGameCreateResponder.NativeMethodInfoPtr_Event_LaunchGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr, 100663381);
		FriendGameCreateResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr, 100663382);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0001ED84 File Offset: 0x0001CF84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495381, XrefRangeEnd = 495386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameCreateResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495386, XrefRangeEnd = 495397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void modelChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameCreateResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0001EDFC File Offset: 0x0001CFFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495397, XrefRangeEnd = 495421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_LaunchGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameCreateResponder.NativeMethodInfoPtr_Event_LaunchGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0001EE30 File Offset: 0x0001D030
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495421, XrefRangeEnd = 495424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendGameCreateResponder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameCreateResponder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameCreateResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002336 File Offset: 0x00000536
	public FriendGameCreateResponder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000077 RID: 119 RVA: 0x0001EE6C File Offset: 0x0001D06C
	// (set) Token: 0x06000078 RID: 120 RVA: 0x0000233F File Offset: 0x0000053F
	public unsafe GameObject friendGameButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameCreateResponder.NativeFieldInfoPtr_friendGameButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameCreateResponder.NativeFieldInfoPtr_friendGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeFieldInfoPtr_friendGameButton;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_Event_LaunchGame_Public_Void_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
