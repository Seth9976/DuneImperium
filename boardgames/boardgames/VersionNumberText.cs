using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class VersionNumberText : MonoBehaviour
{
	// Token: 0x0600010C RID: 268 RVA: 0x00013EA4 File Offset: 0x000120A4
	// Note: this type is marked as 'beforefieldinit'.
	static VersionNumberText()
	{
		Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "VersionNumberText");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr);
		VersionNumberText.NativeFieldInfoPtr_prefixLocaleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr, "prefixLocaleKey");
		VersionNumberText.NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr, 100663508);
		VersionNumberText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr, 100663509);
		VersionNumberText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr, 100663510);
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600010D RID: 269 RVA: 0x00013F24 File Offset: 0x00012124
	public unsafe TMP_Text textField
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983281, XrefRangeEnd = 983288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNumberText.NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00013F64 File Offset: 0x00012164
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983288, XrefRangeEnd = 983310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNumberText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00013F98 File Offset: 0x00012198
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983310, XrefRangeEnd = 983315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionNumberText()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionNumberText>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNumberText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000027B0 File Offset: 0x000009B0
	public VersionNumberText(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000111 RID: 273 RVA: 0x00013FD4 File Offset: 0x000121D4
	// (set) Token: 0x06000112 RID: 274 RVA: 0x000027B9 File Offset: 0x000009B9
	public unsafe string prefixLocaleKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionNumberText.NativeFieldInfoPtr_prefixLocaleKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionNumberText.NativeFieldInfoPtr_prefixLocaleKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeFieldInfoPtr_prefixLocaleKey;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0;

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
