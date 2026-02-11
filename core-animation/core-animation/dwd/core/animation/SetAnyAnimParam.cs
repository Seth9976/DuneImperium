using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000011 RID: 17
	public class SetAnyAnimParam : MonoBehaviour
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00004A64 File Offset: 0x00002C64
		// Note: this type is marked as 'beforefieldinit'.
		static SetAnyAnimParam()
		{
			Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "SetAnyAnimParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr);
			SetAnyAnimParam.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, "animators");
			SetAnyAnimParam.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663366);
			SetAnyAnimParam.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663367);
			SetAnyAnimParam.NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663368);
			SetAnyAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663369);
			SetAnyAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663370);
			SetAnyAnimParam.NativeMethodInfoPtr_canSetParam_Private_Static_Boolean_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663371);
			SetAnyAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr, 100663372);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004B34 File Offset: 0x00002D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263487, XrefRangeEnd = 1263508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolTrue(string paramName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004B78 File Offset: 0x00002D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263508, XrefRangeEnd = 1263529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolFalse(string paramName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004BBC File Offset: 0x00002DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263529, XrefRangeEnd = 1263551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleBoolValue(string paramName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004C00 File Offset: 0x00002E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263551, XrefRangeEnd = 1263572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetTrigger(string paramName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004C44 File Offset: 0x00002E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263572, XrefRangeEnd = 1263593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetTrigger(string paramName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004C88 File Offset: 0x00002E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263593, XrefRangeEnd = 1263598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool canSetParam(Animator anim, int paramToSetNameHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramToSetNameHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr_canSetParam_Private_Static_Boolean_Animator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004CD8 File Offset: 0x00002ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263598, XrefRangeEnd = 1263606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAnyAnimParam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAnyAnimParam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnyAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000025C6 File Offset: 0x000007C6
		public SetAnyAnimParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004D14 File Offset: 0x00002F14
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000025CF File Offset: 0x000007CF
		public unsafe List<Animator> animators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnyAnimParam.NativeFieldInfoPtr_animators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnyAnimParam.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_animators;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_canSetParam_Private_Static_Boolean_Animator_Int32_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
