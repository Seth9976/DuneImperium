using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public sealed class InputAction : Object
	{
		// Token: 0x06000110 RID: 272 RVA: 0x0000A7BC File Offset: 0x000089BC
		// Note: this type is marked as 'beforefieldinit'.
		static InputAction()
		{
			Il2CppClassPointerStore<InputAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "InputAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputAction>.NativeClassPtr);
			InputAction.NativeFieldInfoPtr_InputId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "InputId");
			InputAction.NativeFieldInfoPtr_AdditionalInputIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "AdditionalInputIds");
			InputAction.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "Action");
			InputAction.NativeFieldInfoPtr_priorityNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "priorityNum");
			InputAction.NativeFieldInfoPtr_priorityMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "priorityMod");
			InputAction.NativeMethodInfoPtr_get_PriorityNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100663447);
			InputAction.NativeMethodInfoPtr_get_InputIds_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100663448);
			InputAction.NativeMethodInfoPtr_SetPriorityMod_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100663449);
			InputAction.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100663450);
			InputAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100663451);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		public unsafe int PriorityNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_PriorityNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public unsafe IEnumerable<string> InputIds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1119937, RefRangeEnd = 1119939, XrefRangeStart = 1119928, XrefRangeEnd = 1119937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_InputIds_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000A930 File Offset: 0x00008B30
		[CallerCount(0)]
		public unsafe void SetPriorityMod(int mod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_SetPriorityMod_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A970 File Offset: 0x00008B70
		[CallerCount(0)]
		public unsafe int CompareTo(InputAction otherInputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherInputAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1119954, RefRangeEnd = 1119955, XrefRangeStart = 1119939, XrefRangeEnd = 1119954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002951 File Offset: 0x00000B51
		public InputAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000A9FC File Offset: 0x00008BFC
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000295A File Offset: 0x00000B5A
		public unsafe string InputId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_InputId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_InputId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000AA24 File Offset: 0x00008C24
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002979 File Offset: 0x00000B79
		public unsafe Il2CppStringArray AdditionalInputIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_AdditionalInputIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_AdditionalInputIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000AA54 File Offset: 0x00008C54
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002998 File Offset: 0x00000B98
		public unsafe UnityEventFloat Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000AA84 File Offset: 0x00008C84
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000029B7 File Offset: 0x00000BB7
		public unsafe int priorityNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_priorityNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_priorityNum)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000AAAC File Offset: 0x00008CAC
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000029D2 File Offset: 0x00000BD2
		public unsafe int priorityMod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_priorityMod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_priorityMod)) = value;
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_InputId;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalInputIds;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_priorityNum;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_priorityMod;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_PriorityNum_Public_get_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_InputIds_Public_get_IEnumerable_1_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_SetPriorityMod_Public_Void_Int32_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAction_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
