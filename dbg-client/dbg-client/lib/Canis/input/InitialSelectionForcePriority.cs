using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lib.canis.src.util;
using UnityEngine.EventSystems;

namespace lib.canis.input
{
	// Token: 0x02000028 RID: 40
	public class InitialSelectionForcePriority : InitialSelectionPriority
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00022688 File Offset: 0x00020888
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionForcePriority()
		{
			Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "InitialSelectionForcePriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr);
			InitialSelectionForcePriority.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, "forced");
			InitialSelectionForcePriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, 100663563);
			InitialSelectionForcePriority.NativeMethodInfoPtr_Force_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, 100663564);
			InitialSelectionForcePriority.NativeMethodInfoPtr_Unforce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, 100663565);
			InitialSelectionForcePriority.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, 100663566);
			InitialSelectionForcePriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr, 100663567);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00022730 File Offset: 0x00020930
		[CallerCount(0)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionForcePriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00022778 File Offset: 0x00020978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497605, RefRangeEnd = 497606, XrefRangeStart = 497605, XrefRangeEnd = 497605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Force()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionForcePriority.NativeMethodInfoPtr_Force_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000227AC File Offset: 0x000209AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497606, RefRangeEnd = 497607, XrefRangeStart = 497606, XrefRangeEnd = 497606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unforce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionForcePriority.NativeMethodInfoPtr_Unforce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000227E0 File Offset: 0x000209E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497606, RefRangeEnd = 497607, XrefRangeStart = 497606, XrefRangeEnd = 497607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionForcePriority.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00022824 File Offset: 0x00020A24
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionForcePriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionForcePriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionForcePriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000029AA File Offset: 0x00000BAA
		public InitialSelectionForcePriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00022860 File Offset: 0x00020A60
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000029B3 File Offset: 0x00000BB3
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionForcePriority.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionForcePriority.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Force_Public_Void_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Unforce_Public_Void_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
