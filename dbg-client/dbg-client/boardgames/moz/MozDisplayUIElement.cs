using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x0200011C RID: 284
	public class MozDisplayUIElement : MozDisplayObject
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x000456A0 File Offset: 0x000438A0
		// Note: this type is marked as 'beforefieldinit'.
		static MozDisplayUIElement()
		{
			Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "MozDisplayUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr);
			MozDisplayUIElement.NativeFieldInfoPtr_OnCreateElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, "OnCreateElement");
			MozDisplayUIElement.NativeFieldInfoPtr_elementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, "elementPrefab");
			MozDisplayUIElement.NativeFieldInfoPtr_elementInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, "elementInstance");
			MozDisplayUIElement.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, 100665140);
			MozDisplayUIElement.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, 100665141);
			MozDisplayUIElement.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, 100665142);
			MozDisplayUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr, 100665143);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0004575C File Offset: 0x0004395C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510036, XrefRangeEnd = 510062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozDisplayUIElement.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000457AC File Offset: 0x000439AC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozDisplayUIElement.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000457E8 File Offset: 0x000439E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510062, XrefRangeEnd = 510069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozDisplayUIElement.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00045824 File Offset: 0x00043A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510069, XrefRangeEnd = 510077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozDisplayUIElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozDisplayUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0000823C File Offset: 0x0000643C
		public MozDisplayUIElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00045860 File Offset: 0x00043A60
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00008245 File Offset: 0x00006445
		public unsafe UnityEvent<GameObject> OnCreateElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_OnCreateElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_OnCreateElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00045890 File Offset: 0x00043A90
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00008264 File Offset: 0x00006464
		public unsafe GameObject elementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_elementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_elementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000458C0 File Offset: 0x00043AC0
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00008283 File Offset: 0x00006483
		public unsafe GameObject elementInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_elementInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayUIElement.NativeFieldInfoPtr_elementInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_OnCreateElement;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_elementPrefab;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_elementInstance;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
