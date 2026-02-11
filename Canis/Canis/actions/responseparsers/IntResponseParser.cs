using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class IntResponseParser : ResponseParser<int>
	{
		// Token: 0x06001667 RID: 5735 RVA: 0x000734D4 File Offset: 0x000716D4
		// Note: this type is marked as 'beforefieldinit'.
		static IntResponseParser()
		{
			Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "IntResponseParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr);
			IntResponseParser.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr, "Instance");
			IntResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Int32_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr, 100668396);
			IntResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr, 100668397);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00073540 File Offset: 0x00071740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593456, XrefRangeEnd = 593491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<int> ParseResponse(Match match, Object responseMessage)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Int32_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000735B0 File Offset: 0x000717B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593491, XrefRangeEnd = 593494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntResponseParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntResponseParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0000AC4B File Offset: 0x00008E4B
		public IntResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x000735EC File Offset: 0x000717EC
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x0000AC54 File Offset: 0x00008E54
		public unsafe static IntResponseParser Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntResponseParser.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntResponseParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntResponseParser.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Int32_Match_Object_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
