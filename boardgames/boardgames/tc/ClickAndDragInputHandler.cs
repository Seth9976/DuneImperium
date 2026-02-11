using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace tc
{
	// Token: 0x0200002C RID: 44
	public class ClickAndDragInputHandler : MonoBehaviour
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00015838 File Offset: 0x00013A38
		// Note: this type is marked as 'beforefieldinit'.
		static ClickAndDragInputHandler()
		{
			Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "tc", "ClickAndDragInputHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr);
			ClickAndDragInputHandler.NativeFieldInfoPtr_isBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, "isBlocker");
			ClickAndDragInputHandler.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, "onClick");
			ClickAndDragInputHandler.NativeMethodInfoPtr_get_IsBlocker_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, 100663587);
			ClickAndDragInputHandler.NativeMethodInfoPtr_get_OnClick_Public_get_ClickEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, 100663588);
			ClickAndDragInputHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, 100663589);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000158CC File Offset: 0x00013ACC
		public unsafe bool IsBlocker
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickAndDragInputHandler.NativeMethodInfoPtr_get_IsBlocker_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00015908 File Offset: 0x00013B08
		public unsafe ClickAndDragInputHandler.ClickEvent OnClick
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickAndDragInputHandler.NativeMethodInfoPtr_get_OnClick_Public_get_ClickEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClickAndDragInputHandler.ClickEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00015948 File Offset: 0x00013B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983949, XrefRangeEnd = 983957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickAndDragInputHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickAndDragInputHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002BCA File Offset: 0x00000DCA
		public ClickAndDragInputHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00015984 File Offset: 0x00013B84
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public unsafe bool isBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickAndDragInputHandler.NativeFieldInfoPtr_isBlocker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickAndDragInputHandler.NativeFieldInfoPtr_isBlocker)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000159AC File Offset: 0x00013BAC
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002BEE File Offset: 0x00000DEE
		public unsafe ClickAndDragInputHandler.ClickEvent onClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickAndDragInputHandler.NativeFieldInfoPtr_onClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClickAndDragInputHandler.ClickEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickAndDragInputHandler.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_isBlocker;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_onClick;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlocker_Public_get_Boolean_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_OnClick_Public_get_ClickEvent_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001A3 RID: 419
		public class ClickEvent : UnityEvent<EntityComponent>
		{
			// Token: 0x0600148B RID: 5259 RVA: 0x0000BA23 File Offset: 0x00009C23
			// Note: this type is marked as 'beforefieldinit'.
			static ClickEvent()
			{
				Il2CppClassPointerStore<ClickAndDragInputHandler.ClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClickAndDragInputHandler>.NativeClassPtr, "ClickEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickAndDragInputHandler.ClickEvent>.NativeClassPtr);
				ClickAndDragInputHandler.ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickAndDragInputHandler.ClickEvent>.NativeClassPtr, 100663590);
			}

			// Token: 0x0600148C RID: 5260 RVA: 0x00050670 File Offset: 0x0004E870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983946, XrefRangeEnd = 983949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClickEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickAndDragInputHandler.ClickEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickAndDragInputHandler.ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600148D RID: 5261 RVA: 0x0000BA57 File Offset: 0x00009C57
			public ClickEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
