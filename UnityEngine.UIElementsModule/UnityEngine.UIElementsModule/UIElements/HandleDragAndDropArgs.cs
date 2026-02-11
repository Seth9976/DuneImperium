using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AE RID: 174
	public sealed class HandleDragAndDropArgs : ValueType
	{
		// Token: 0x0600107E RID: 4222 RVA: 0x00057020 File Offset: 0x00055220
		// Note: this type is marked as 'beforefieldinit'.
		static HandleDragAndDropArgs()
		{
			Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "HandleDragAndDropArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr);
			HandleDragAndDropArgs.NativeFieldInfoPtr_m_DragAndDropArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr, "m_DragAndDropArgs");
			HandleDragAndDropArgs.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr, "<position>k__BackingField");
			HandleDragAndDropArgs.NativeMethodInfoPtr__ctor_Internal_Void_Vector2_DragAndDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr, 100665662);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0005708C File Offset: 0x0005528C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310361, RefRangeEnd = 310363, XrefRangeStart = 310360, XrefRangeEnd = 310361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragAndDropArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleDragAndDropArgs.NativeMethodInfoPtr__ctor_Internal_Void_Vector2_DragAndDropArgs_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00008494 File Offset: 0x00006694
		public HandleDragAndDropArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0000849D File Offset: 0x0000669D
		public HandleDragAndDropArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleDragAndDropArgs>.NativeClassPtr))
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000570F0 File Offset: 0x000552F0
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x000084AF File Offset: 0x000066AF
		public DragAndDropArgs m_DragAndDropArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleDragAndDropArgs.NativeFieldInfoPtr_m_DragAndDropArgs);
				return new DragAndDropArgs(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleDragAndDropArgs.NativeFieldInfoPtr_m_DragAndDropArgs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DragAndDropArgs>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00057120 File Offset: 0x00055320
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x000084DD File Offset: 0x000066DD
		public unsafe Vector2 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleDragAndDropArgs.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleDragAndDropArgs.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x000084F8 File Offset: 0x000066F8
		public Vector2 position
		{
			get
			{
				return this._position_k__BackingField;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00008500 File Offset: 0x00006700
		public Object target
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0000850D File Offset: 0x0000670D
		public int insertAtIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0000851A File Offset: 0x0000671A
		public int parentId
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x00008527 File Offset: 0x00006727
		public int childIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00008534 File Offset: 0x00006734
		public DragAndDropPosition dropPosition
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00008541 File Offset: 0x00006741
		public DragAndDropData dragAndDropData
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_m_DragAndDropArgs;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Vector2_DragAndDropArgs_0;
	}
}
