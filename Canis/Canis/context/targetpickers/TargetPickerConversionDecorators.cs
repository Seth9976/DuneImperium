using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages.outgoing;

namespace Canis.context.targetpickers
{
	// Token: 0x02000127 RID: 295
	public static class TargetPickerConversionDecorators : Object
	{
		// Token: 0x06000DB8 RID: 3512 RVA: 0x00006FE6 File Offset: 0x000051E6
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPickerConversionDecorators()
		{
			Il2CppClassPointerStore<TargetPickerConversionDecorators>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "TargetPickerConversionDecorators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPickerConversionDecorators>.NativeClassPtr);
			TargetPickerConversionDecorators.NativeMethodInfoPtr_AsSelectTargetsFrom_Public_Static_TargetPicker_1_EntityIDTargetResponses_TargetPicker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPickerConversionDecorators>.NativeClassPtr, 100666345);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00053DC0 File Offset: 0x00051FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576929, XrefRangeEnd = 576938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker<EntityIDTargetResponses> AsSelectTargetsFrom(this TargetPicker picker)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(picker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPickerConversionDecorators.NativeMethodInfoPtr_AsSelectTargetsFrom_Public_Static_TargetPicker_1_EntityIDTargetResponses_TargetPicker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<EntityIDTargetResponses>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0000701F File Offset: 0x0000521F
		public TargetPickerConversionDecorators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_AsSelectTargetsFrom_Public_Static_TargetPicker_1_EntityIDTargetResponses_TargetPicker_0;
	}
}
