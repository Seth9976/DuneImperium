using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace Canis.actions.responseparsers
{
	// Token: 0x0200021B RID: 539
	[Serializable]
	public class TargetResponsesParser : ResponseParser<TargetResponse>
	{
		// Token: 0x06001688 RID: 5768 RVA: 0x00073CFC File Offset: 0x00071EFC
		// Note: this type is marked as 'beforefieldinit'.
		static TargetResponsesParser()
		{
			Il2CppClassPointerStore<TargetResponsesParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "TargetResponsesParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetResponsesParser>.NativeClassPtr);
			TargetResponsesParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_TargetResponse_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponsesParser>.NativeClassPtr, 100668419);
			TargetResponsesParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponsesParser>.NativeClassPtr, 100668420);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00073D54 File Offset: 0x00071F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593537, XrefRangeEnd = 593547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetResponse> ParseResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetResponsesParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_TargetResponse_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponse>>(intPtr3) : null;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00073DC4 File Offset: 0x00071FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593547, XrefRangeEnd = 593550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponsesParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetResponsesParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponsesParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0000ACE3 File Offset: 0x00008EE3
		public TargetResponsesParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_TargetResponse_Match_Object_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
