using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.drag
{
	// Token: 0x02000073 RID: 115
	public class SingleDragProcessor : global::Il2CppSystem.Object
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x000146FC File Offset: 0x000128FC
		// Note: this type is marked as 'beforefieldinit'.
		static SingleDragProcessor()
		{
			Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "SingleDragProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr);
			SingleDragProcessor.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "transform");
			SingleDragProcessor.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "config");
			SingleDragProcessor.NativeFieldInfoPtr_activePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "activePresses");
			SingleDragProcessor.NativeFieldInfoPtr_dragPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "dragPress");
			SingleDragProcessor.NativeFieldInfoPtr_isDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "isDragging");
			SingleDragProcessor.NativeFieldInfoPtr_readyForCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, "readyForCleanup");
			SingleDragProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IDragConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, 100663790);
			SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, 100663791);
			SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, 100663792);
			SingleDragProcessor.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, 100663793);
			SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr, 100663794);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00014808 File Offset: 0x00012A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122690, XrefRangeEnd = 1122700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleDragProcessor(Transform transform, IDragConfig config)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleDragProcessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleDragProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IDragConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00014868 File Offset: 0x00012A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122700, XrefRangeEnd = 1122717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Process(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000148AC File Offset: 0x00012AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122717, XrefRangeEnd = 1122732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Update(float unscaledTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000148EC File Offset: 0x00012AEC
		public unsafe virtual Transform Transform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleDragProcessor.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001492C File Offset: 0x00012B2C
		public unsafe virtual bool dwd.core.input.transforms.IPressProcessor.ReadyForCleanUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleDragProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00004862 File Offset: 0x00002A62
		public SingleDragProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00014968 File Offset: 0x00012B68
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000486B File Offset: 0x00002A6B
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00014998 File Offset: 0x00012B98
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000488A File Offset: 0x00002A8A
		public unsafe IDragConfig config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDragConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000149C8 File Offset: 0x00012BC8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000048A9 File Offset: 0x00002AA9
		public unsafe HashSet<Press> activePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_activePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Press>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_activePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000149F8 File Offset: 0x00012BF8
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x000048C8 File Offset: 0x00002AC8
		public unsafe Press dragPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_dragPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Press>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_dragPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00014A28 File Offset: 0x00012C28
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x000048E7 File Offset: 0x00002AE7
		public unsafe bool isDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_isDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_isDragging)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00014A50 File Offset: 0x00012C50
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00004902 File Offset: 0x00002B02
		public unsafe bool readyForCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_readyForCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleDragProcessor.NativeFieldInfoPtr_readyForCleanup)) = value;
			}
		}

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_config;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_activePresses;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_dragPress;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_isDragging;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_readyForCleanup;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_IDragConfig_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0;
	}
}
