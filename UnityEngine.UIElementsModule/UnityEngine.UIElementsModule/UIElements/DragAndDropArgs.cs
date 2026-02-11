using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A8 RID: 168
	public sealed class DragAndDropArgs : ValueType
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x00056400 File Offset: 0x00054600
		// Note: this type is marked as 'beforefieldinit'.
		static DragAndDropArgs()
		{
			Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DragAndDropArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr);
			DragAndDropArgs.NativeFieldInfoPtr__target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<target>k__BackingField");
			DragAndDropArgs.NativeFieldInfoPtr__insertAtIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<insertAtIndex>k__BackingField");
			DragAndDropArgs.NativeFieldInfoPtr__parentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<parentId>k__BackingField");
			DragAndDropArgs.NativeFieldInfoPtr__childIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<childIndex>k__BackingField");
			DragAndDropArgs.NativeFieldInfoPtr__dragAndDropPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<dragAndDropPosition>k__BackingField");
			DragAndDropArgs.NativeFieldInfoPtr__dragAndDropData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, "<dragAndDropData>k__BackingField");
			DragAndDropArgs.NativeMethodInfoPtr_set_target_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665642);
			DragAndDropArgs.NativeMethodInfoPtr_get_insertAtIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665643);
			DragAndDropArgs.NativeMethodInfoPtr_set_insertAtIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665644);
			DragAndDropArgs.NativeMethodInfoPtr_get_parentId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665645);
			DragAndDropArgs.NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665646);
			DragAndDropArgs.NativeMethodInfoPtr_get_childIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665647);
			DragAndDropArgs.NativeMethodInfoPtr_set_childIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665648);
			DragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropPosition_Public_Virtual_Final_New_get_DragAndDropPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665649);
			DragAndDropArgs.NativeMethodInfoPtr_set_dragAndDropPosition_Public_set_Void_DragAndDropPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665650);
			DragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropData_Public_Virtual_Final_New_get_DragAndDropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665651);
			DragAndDropArgs.NativeMethodInfoPtr_set_dragAndDropData_Public_set_Void_DragAndDropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, 100665652);
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00008388 File Offset: 0x00006588
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x00056584 File Offset: 0x00054784
		public unsafe Object target
		{
			get
			{
				return this._target_k__BackingField;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_target_Public_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000565CC File Offset: 0x000547CC
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x00056610 File Offset: 0x00054810
		public unsafe int insertAtIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_get_insertAtIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_insertAtIndex_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00056654 File Offset: 0x00054854
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00056698 File Offset: 0x00054898
		public unsafe int parentId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_get_parentId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x000566DC File Offset: 0x000548DC
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00056720 File Offset: 0x00054920
		public unsafe int childIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_get_childIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_childIndex_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00056764 File Offset: 0x00054964
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x000567A8 File Offset: 0x000549A8
		public unsafe DragAndDropPosition dragAndDropPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropPosition_Public_Virtual_Final_New_get_DragAndDropPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_dragAndDropPosition_Public_set_Void_DragAndDropPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000567EC File Offset: 0x000549EC
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00056830 File Offset: 0x00054A30
		public unsafe DragAndDropData dragAndDropData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_get_dragAndDropData_Public_Virtual_Final_New_get_DragAndDropData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragAndDropData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropArgs.NativeMethodInfoPtr_set_dragAndDropData_Public_set_Void_DragAndDropData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000082C3 File Offset: 0x000064C3
		public DragAndDropArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000082CC File Offset: 0x000064CC
		public DragAndDropArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00056878 File Offset: 0x00054A78
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x000082DE File Offset: 0x000064DE
		public unsafe Object _target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x000568A8 File Offset: 0x00054AA8
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x000082FD File Offset: 0x000064FD
		public unsafe int _insertAtIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__insertAtIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__insertAtIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x000568D0 File Offset: 0x00054AD0
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00008318 File Offset: 0x00006518
		public unsafe int _parentId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__parentId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__parentId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x000568F8 File Offset: 0x00054AF8
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00008333 File Offset: 0x00006533
		public unsafe int _childIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__childIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__childIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00056920 File Offset: 0x00054B20
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0000834E File Offset: 0x0000654E
		public unsafe DragAndDropPosition _dragAndDropPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__dragAndDropPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__dragAndDropPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00056948 File Offset: 0x00054B48
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x00008369 File Offset: 0x00006569
		public unsafe DragAndDropData _dragAndDropData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__dragAndDropData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragAndDropData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragAndDropArgs.NativeFieldInfoPtr__dragAndDropData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr__target_k__BackingField;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr__insertAtIndex_k__BackingField;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr__parentId_k__BackingField;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr__childIndex_k__BackingField;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr__dragAndDropPosition_k__BackingField;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr__dragAndDropData_k__BackingField;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Public_set_Void_Object_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_insertAtIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_set_insertAtIndex_Public_set_Void_Int32_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_parentId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_childIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_set_childIndex_Public_set_Void_Int32_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDropPosition_Public_Virtual_Final_New_get_DragAndDropPosition_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_set_dragAndDropPosition_Public_set_Void_DragAndDropPosition_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDropData_Public_Virtual_Final_New_get_DragAndDropData_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_set_dragAndDropData_Public_set_Void_DragAndDropData_0;
	}
}
