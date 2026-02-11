using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000010 RID: 16
	public class SetAnimParam : MonoBehaviour
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00004634 File Offset: 0x00002834
		// Note: this type is marked as 'beforefieldinit'.
		static SetAnimParam()
		{
			Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "SetAnimParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr);
			SetAnimParam.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, "animators");
			SetAnimParam.NativeFieldInfoPtr_paramName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, "paramName");
			SetAnimParam.NativeFieldInfoPtr_cachedParamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, "cachedParamID");
			SetAnimParam.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663355);
			SetAnimParam.NativeMethodInfoPtr_initCacheIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663356);
			SetAnimParam.NativeMethodInfoPtr_Event_SetBoolValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663357);
			SetAnimParam.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663358);
			SetAnimParam.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663359);
			SetAnimParam.NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663360);
			SetAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663361);
			SetAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663362);
			SetAnimParam.NativeMethodInfoPtr_Event_SetFloatValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663363);
			SetAnimParam.NativeMethodInfoPtr_Event_SetIntValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663364);
			SetAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000477C File Offset: 0x0000297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263345, XrefRangeEnd = 1263346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000047B0 File Offset: 0x000029B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initCacheIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_initCacheIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000047E4 File Offset: 0x000029E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263346, XrefRangeEnd = 1263362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolValue(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetBoolValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004824 File Offset: 0x00002A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263362, XrefRangeEnd = 1263378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolTrue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004858 File Offset: 0x00002A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263378, XrefRangeEnd = 1263394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolFalse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000488C File Offset: 0x00002A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263394, XrefRangeEnd = 1263411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleBoolValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000048C0 File Offset: 0x00002AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263411, XrefRangeEnd = 1263427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000048F4 File Offset: 0x00002AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263427, XrefRangeEnd = 1263443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004928 File Offset: 0x00002B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263443, XrefRangeEnd = 1263459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetFloatValue(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetFloatValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004968 File Offset: 0x00002B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263459, XrefRangeEnd = 1263475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetIntValue(int newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr_Event_SetIntValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000049A8 File Offset: 0x00002BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263475, XrefRangeEnd = 1263487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAnimParam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAnimParam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002564 File Offset: 0x00000764
		public SetAnimParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000049E4 File Offset: 0x00002BE4
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000256D File Offset: 0x0000076D
		public unsafe List<Animator> animators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_animators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004A14 File Offset: 0x00002C14
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe string paramName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_paramName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_paramName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00004A3C File Offset: 0x00002C3C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe int cachedParamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_cachedParamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimParam.NativeFieldInfoPtr_cachedParamID)) = value;
			}
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_animators;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_paramName;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_cachedParamID;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_initCacheIfNeeded_Private_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolValue_Public_Void_Boolean_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleBoolValue_Public_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetTrigger_Public_Void_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetFloatValue_Public_Void_Single_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetIntValue_Public_Void_Int32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
