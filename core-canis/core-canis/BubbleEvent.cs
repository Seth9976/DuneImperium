using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200002A RID: 42
public class BubbleEvent : DWDEvent
{
	// Token: 0x06000403 RID: 1027 RVA: 0x00023188 File Offset: 0x00021388
	// Note: this type is marked as 'beforefieldinit'.
	static BubbleEvent()
	{
		Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "BubbleEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr);
		BubbleEvent.NativeFieldInfoPtr__IsBubbling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, "<IsBubbling>k__BackingField");
		BubbleEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663863);
		BubbleEvent.NativeMethodInfoPtr_get_Source_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663864);
		BubbleEvent.NativeMethodInfoPtr_set_Source_Public_Virtual_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663865);
		BubbleEvent.NativeMethodInfoPtr_get_IsBubbling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663866);
		BubbleEvent.NativeMethodInfoPtr_set_IsBubbling_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663867);
		BubbleEvent.NativeMethodInfoPtr_StopBubbling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr, 100663868);
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00023244 File Offset: 0x00021444
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 855902, RefRangeEnd = 855907, XrefRangeStart = 855901, XrefRangeEnd = 855902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BubbleEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BubbleEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BubbleEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000405 RID: 1029 RVA: 0x00023280 File Offset: 0x00021480
	// (set) Token: 0x06000406 RID: 1030 RVA: 0x000232CC File Offset: 0x000214CC
	public unsafe override Object Source
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BubbleEvent.NativeMethodInfoPtr_get_Source_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855907, XrefRangeEnd = 855916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BubbleEvent.NativeMethodInfoPtr_set_Source_Public_Virtual_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000407 RID: 1031 RVA: 0x0002331C File Offset: 0x0002151C
	// (set) Token: 0x06000408 RID: 1032 RVA: 0x00023358 File Offset: 0x00021558
	public unsafe bool IsBubbling
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BubbleEvent.NativeMethodInfoPtr_get_IsBubbling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BubbleEvent.NativeMethodInfoPtr_set_IsBubbling_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00023398 File Offset: 0x00021598
	[CallerCount(0)]
	public unsafe void StopBubbling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BubbleEvent.NativeMethodInfoPtr_StopBubbling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00003912 File Offset: 0x00001B12
	public BubbleEvent(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x0600040B RID: 1035 RVA: 0x000233CC File Offset: 0x000215CC
	// (set) Token: 0x0600040C RID: 1036 RVA: 0x0000391B File Offset: 0x00001B1B
	public unsafe bool _IsBubbling_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BubbleEvent.NativeFieldInfoPtr__IsBubbling_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BubbleEvent.NativeFieldInfoPtr__IsBubbling_k__BackingField)) = value;
		}
	}

	// Token: 0x040002F1 RID: 753
	private static readonly IntPtr NativeFieldInfoPtr__IsBubbling_k__BackingField;

	// Token: 0x040002F2 RID: 754
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x040002F3 RID: 755
	private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_get_Object_0;

	// Token: 0x040002F4 RID: 756
	private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_set_Void_Object_0;

	// Token: 0x040002F5 RID: 757
	private static readonly IntPtr NativeMethodInfoPtr_get_IsBubbling_Public_get_Boolean_0;

	// Token: 0x040002F6 RID: 758
	private static readonly IntPtr NativeMethodInfoPtr_set_IsBubbling_Private_set_Void_Boolean_0;

	// Token: 0x040002F7 RID: 759
	private static readonly IntPtr NativeMethodInfoPtr_StopBubbling_Public_Void_0;
}
