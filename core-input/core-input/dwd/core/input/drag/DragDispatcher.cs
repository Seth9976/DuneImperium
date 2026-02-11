using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.drag
{
	// Token: 0x0200006E RID: 110
	public class DragDispatcher : MonoBehaviour
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0001427C File Offset: 0x0001247C
		// Note: this type is marked as 'beforefieldinit'.
		static DragDispatcher()
		{
			Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "DragDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr);
			DragDispatcher.NativeFieldInfoPtr_dragSlopInches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, "dragSlopInches");
			DragDispatcher.NativeFieldInfoPtr_processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, "processor");
			DragDispatcher.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, "input");
			DragDispatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663779);
			DragDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663780);
			DragDispatcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663781);
			DragDispatcher.NativeMethodInfoPtr_processorFactory_Private_SingleDragProcessor_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663782);
			DragDispatcher.NativeMethodInfoPtr_get_DragSlop_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663783);
			DragDispatcher.NativeMethodInfoPtr_Find_Public_Static_DragDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663784);
			DragDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr, 100663785);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00014374 File Offset: 0x00012574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122595, XrefRangeEnd = 1122645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000143A8 File Offset: 0x000125A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122645, XrefRangeEnd = 1122666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000143DC File Offset: 0x000125DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122666, XrefRangeEnd = 1122669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00014410 File Offset: 0x00012610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122669, XrefRangeEnd = 1122682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleDragProcessor processorFactory(Transform tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_processorFactory_Private_SingleDragProcessor_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SingleDragProcessor>(intPtr3) : null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00014460 File Offset: 0x00012660
		public unsafe virtual float DragSlop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122682, XrefRangeEnd = 1122686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_get_DragSlop_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001449C File Offset: 0x0001269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122686, XrefRangeEnd = 1122689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DragDispatcher Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr_Find_Public_Static_DragDispatcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragDispatcher>(intPtr3) : null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000144D0 File Offset: 0x000126D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122689, XrefRangeEnd = 1122690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00004702 File Offset: 0x00002902
		public DragDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001450C File Offset: 0x0001270C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000470B File Offset: 0x0000290B
		public unsafe float dragSlopInches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_dragSlopInches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_dragSlopInches)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00014534 File Offset: 0x00012734
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00004726 File Offset: 0x00002926
		public unsafe PressProcessors processor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_processor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PressProcessors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_processor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00014564 File Offset: 0x00012764
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00004745 File Offset: 0x00002945
		public unsafe InputManager input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragDispatcher.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_dragSlopInches;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_processor;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_processorFactory_Private_SingleDragProcessor_Transform_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSlop_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_DragDispatcher_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
