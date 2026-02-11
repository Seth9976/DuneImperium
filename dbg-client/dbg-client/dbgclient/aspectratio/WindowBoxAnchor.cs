using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.aspectratio
{
	// Token: 0x020000E2 RID: 226
	public class WindowBoxAnchor : MonoBehaviour
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x0003C54C File Offset: 0x0003A74C
		// Note: this type is marked as 'beforefieldinit'.
		static WindowBoxAnchor()
		{
			Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "WindowBoxAnchor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr);
			WindowBoxAnchor.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, "Side");
			WindowBoxAnchor.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, "Buffer");
			WindowBoxAnchor.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, "_rectTransform");
			WindowBoxAnchor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, 100664725);
			WindowBoxAnchor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, 100664726);
			WindowBoxAnchor.NativeMethodInfoPtr_SetTransformProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, 100664727);
			WindowBoxAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr, 100664728);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0003C608 File Offset: 0x0003A808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506203, XrefRangeEnd = 506204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowBoxAnchor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0003C63C File Offset: 0x0003A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowBoxAnchor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0003C670 File Offset: 0x0003A870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506228, RefRangeEnd = 506230, XrefRangeStart = 506204, XrefRangeEnd = 506228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowBoxAnchor.NativeMethodInfoPtr_SetTransformProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0003C6A4 File Offset: 0x0003A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506230, XrefRangeEnd = 506235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowBoxAnchor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowBoxAnchor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowBoxAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public WindowBoxAnchor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00006ADD File Offset: 0x00004CDD
		public unsafe WindowBoxAnchor.BoxSide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0003C708 File Offset: 0x0003A908
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public unsafe float Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr_Buffer)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0003C730 File Offset: 0x0003A930
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00006B13 File Offset: 0x00004D13
		public unsafe RectTransform _rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr__rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowBoxAnchor.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformProperties_Private_Void_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000333 RID: 819
		public enum BoxSide
		{
			// Token: 0x04001844 RID: 6212
			Top,
			// Token: 0x04001845 RID: 6213
			Bottom,
			// Token: 0x04001846 RID: 6214
			Left,
			// Token: 0x04001847 RID: 6215
			Right
		}
	}
}
