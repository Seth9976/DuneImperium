using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000012 RID: 18
public class SlantedButtons : MonoBehaviour
{
	// Token: 0x0600009B RID: 155 RVA: 0x0001F684 File Offset: 0x0001D884
	// Note: this type is marked as 'beforefieldinit'.
	static SlantedButtons()
	{
		Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "SlantedButtons");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr);
		SlantedButtons.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr, "m_Image");
		SlantedButtons.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr, "m_Sprite");
		SlantedButtons.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr, 100663419);
		SlantedButtons.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr, 100663420);
		SlantedButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr, 100663421);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0001F718 File Offset: 0x0001D918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495804, XrefRangeEnd = 495870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsRaycastLocationValid(Vector2 screenPosition, Camera eventCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlantedButtons.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0001F774 File Offset: 0x0001D974
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495870, XrefRangeEnd = 495874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlantedButtons.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlantedButtons()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlantedButtons>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlantedButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000242B File Offset: 0x0000062B
	public SlantedButtons(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
	// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002434 File Offset: 0x00000634
	public unsafe Image m_Image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlantedButtons.NativeFieldInfoPtr_m_Image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlantedButtons.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x0001F814 File Offset: 0x0001DA14
	// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002453 File Offset: 0x00000653
	public unsafe Sprite m_Sprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlantedButtons.NativeFieldInfoPtr_m_Sprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlantedButtons.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeFieldInfoPtr_m_Image;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
