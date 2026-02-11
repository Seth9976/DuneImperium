using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000122 RID: 290
	public class DebugUIHandlerContainer : MonoBehaviour
	{
		// Token: 0x060012EB RID: 4843 RVA: 0x000554BC File Offset: 0x000536BC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerContainer()
		{
			Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr);
			DebugUIHandlerContainer.NativeFieldInfoPtr_contentHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, "contentHolder");
			DebugUIHandlerContainer.NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, 100666058);
			DebugUIHandlerContainer.NativeMethodInfoPtr_GetLastItem_Internal_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, 100666059);
			DebugUIHandlerContainer.NativeMethodInfoPtr_IsDirectChild_Internal_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, 100666060);
			DebugUIHandlerContainer.NativeMethodInfoPtr_GetActiveChildren_Private_List_1_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, 100666061);
			DebugUIHandlerContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, 100666062);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00055564 File Offset: 0x00053764
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 980451, RefRangeEnd = 980462, XrefRangeStart = 980445, XrefRangeEnd = 980451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerWidget GetFirstItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000555A4 File Offset: 0x000537A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 980468, RefRangeEnd = 980477, XrefRangeStart = 980462, XrefRangeEnd = 980468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerWidget GetLastItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.NativeMethodInfoPtr_GetLastItem_Internal_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000555E4 File Offset: 0x000537E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 980493, RefRangeEnd = 980502, XrefRangeStart = 980477, XrefRangeEnd = 980493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDirectChild(DebugUIHandlerWidget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.NativeMethodInfoPtr_IsDirectChild_Internal_Boolean_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00055634 File Offset: 0x00053834
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 980538, RefRangeEnd = 980541, XrefRangeStart = 980502, XrefRangeEnd = 980538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DebugUIHandlerWidget> GetActiveChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.NativeMethodInfoPtr_GetActiveChildren_Private_List_1_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DebugUIHandlerWidget>>(intPtr3) : null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00055674 File Offset: 0x00053874
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00009A81 File Offset: 0x00007C81
		public DebugUIHandlerContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000556B0 File Offset: 0x000538B0
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00009A8A File Offset: 0x00007C8A
		public unsafe RectTransform contentHolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerContainer.NativeFieldInfoPtr_contentHolder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerContainer.NativeFieldInfoPtr_contentHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_contentHolder;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_GetLastItem_Internal_DebugUIHandlerWidget_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectChild_Internal_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveChildren_Private_List_1_DebugUIHandlerWidget_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000218 RID: 536
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerContainer+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001B42 RID: 6978 RVA: 0x0006F678 File Offset: 0x0006D878
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerContainer>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr);
				DebugUIHandlerContainer.__c__DisplayClass3_0.NativeFieldInfoPtr_widget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr, "widget");
				DebugUIHandlerContainer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr, 100666063);
				DebugUIHandlerContainer.__c__DisplayClass3_0.NativeMethodInfoPtr__IsDirectChild_b__0_Internal_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr, 100666064);
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x0006F6E0 File Offset: 0x0006D8E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerContainer.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B44 RID: 6980 RVA: 0x0006F71C File Offset: 0x0006D91C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980441, XrefRangeEnd = 980445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsDirectChild_b__0(DebugUIHandlerWidget x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerContainer.__c__DisplayClass3_0.NativeMethodInfoPtr__IsDirectChild_b__0_Internal_Boolean_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B45 RID: 6981 RVA: 0x0000D9BA File Offset: 0x0000BBBA
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0006F76C File Offset: 0x0006D96C
			// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000D9C3 File Offset: 0x0000BBC3
			public unsafe DebugUIHandlerWidget widget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerContainer.__c__DisplayClass3_0.NativeFieldInfoPtr_widget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerContainer.__c__DisplayClass3_0.NativeFieldInfoPtr_widget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013DC RID: 5084
			private static readonly IntPtr NativeFieldInfoPtr_widget;

			// Token: 0x040013DD RID: 5085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013DE RID: 5086
			private static readonly IntPtr NativeMethodInfoPtr__IsDirectChild_b__0_Internal_Boolean_DebugUIHandlerWidget_0;
		}
	}
}
