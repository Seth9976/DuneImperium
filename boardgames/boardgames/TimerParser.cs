using System;
using Canis.messages.timer;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames
{
	// Token: 0x02000100 RID: 256
	public class TimerParser : MonoBehaviour
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x000381FC File Offset: 0x000363FC
		// Note: this type is marked as 'beforefieldinit'.
		static TimerParser()
		{
			Il2CppClassPointerStore<TimerParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "TimerParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerParser>.NativeClassPtr);
			TimerParser.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, "queue");
			TimerParser.NativeFieldInfoPtr_displayTimersOtherThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, "displayTimersOtherThread");
			TimerParser.NativeFieldInfoPtr_hideTimersOtherThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, "hideTimersOtherThread");
			TimerParser.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665253);
			TimerParser.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665254);
			TimerParser.NativeMethodInfoPtr_handle_Private_Void_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665255);
			TimerParser.NativeMethodInfoPtr_handle_Private_Void_HideTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665256);
			TimerParser.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665257);
			TimerParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerParser>.NativeClassPtr, 100665258);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000382E0 File Offset: 0x000364E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995455, XrefRangeEnd = 995478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00038314 File Offset: 0x00036514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995478, XrefRangeEnd = 995504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00038348 File Offset: 0x00036548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995504, XrefRangeEnd = 995510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(DisplayTimer displayMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr_handle_Private_Void_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003838C File Offset: 0x0003658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995510, XrefRangeEnd = 995516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(HideTimer hideMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hideMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr_handle_Private_Void_HideTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000383D0 File Offset: 0x000365D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995516, XrefRangeEnd = 995538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00038404 File Offset: 0x00036604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995538, XrefRangeEnd = 995553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00007A44 File Offset: 0x00005C44
		public TimerParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00038440 File Offset: 0x00036640
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00007A4D File Offset: 0x00005C4D
		public unsafe SessionProvider queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00038470 File Offset: 0x00036670
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00007A6C File Offset: 0x00005C6C
		public unsafe List<DisplayTimer> displayTimersOtherThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_displayTimersOtherThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DisplayTimer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_displayTimersOtherThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000384A0 File Offset: 0x000366A0
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00007A8B File Offset: 0x00005C8B
		public unsafe List<HideTimer> hideTimersOtherThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_hideTimersOtherThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HideTimer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerParser.NativeFieldInfoPtr_hideTimersOtherThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_displayTimersOtherThread;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_hideTimersOtherThread;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_DisplayTimer_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_HideTimer_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
