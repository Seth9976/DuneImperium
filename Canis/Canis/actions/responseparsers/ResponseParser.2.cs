using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class ResponseParser<TargetResponseType> : ResponseParser
	{
		// Token: 0x0600167D RID: 5757 RVA: 0x000739B0 File Offset: 0x00071BB0
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseParser()
		{
			Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "ResponseParser`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetResponseType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr);
			ResponseParser<TargetResponseType>.NativeMethodInfoPtr_ParseResponseBase_Public_Virtual_Final_IEnumerable_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr, 100668414);
			ResponseParser<TargetResponseType>.NativeMethodInfoPtr_ParseResponse_Public_Abstract_Virtual_New_IEnumerable_1_TargetResponseType_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr, 100668415);
			ResponseParser<TargetResponseType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr, 100668416);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00073A58 File Offset: 0x00071C58
		[CallerCount(0)]
		public unsafe override IEnumerable ParseResponseBase(Match match, Object responseMessage)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseParser<TargetResponseType>.NativeMethodInfoPtr_ParseResponseBase_Public_Virtual_Final_IEnumerable_Match_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00073ABC File Offset: 0x00071CBC
		[CallerCount(0)]
		public unsafe virtual IEnumerable<TargetResponseType> ParseResponse(Match match, Object responseMessage)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResponseParser<TargetResponseType>.NativeMethodInfoPtr_ParseResponse_Public_Abstract_Virtual_New_IEnumerable_1_TargetResponseType_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponseType>>(intPtr3) : null;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00073B2C File Offset: 0x00071D2C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResponseParser<TargetResponseType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseParser<TargetResponseType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0000ACB2 File Offset: 0x00008EB2
		public ResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponseBase_Public_Virtual_Final_IEnumerable_Match_Object_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Abstract_Virtual_New_IEnumerable_1_TargetResponseType_Match_Object_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
