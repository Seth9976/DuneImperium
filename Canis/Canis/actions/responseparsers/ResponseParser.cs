using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000218 RID: 536
	public class ResponseParser : Object
	{
		// Token: 0x06001679 RID: 5753 RVA: 0x000738AC File Offset: 0x00071AAC
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseParser()
		{
			Il2CppClassPointerStore<ResponseParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "ResponseParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResponseParser>.NativeClassPtr);
			ResponseParser.NativeMethodInfoPtr_ParseResponseBase_Public_Abstract_Virtual_New_IEnumerable_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseParser>.NativeClassPtr, 100668412);
			ResponseParser.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseParser>.NativeClassPtr, 100668413);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00073904 File Offset: 0x00071B04
		[CallerCount(0)]
		public unsafe virtual IEnumerable ParseResponseBase(Match match, Object responseMessage)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResponseParser.NativeMethodInfoPtr_ParseResponseBase_Public_Abstract_Virtual_New_IEnumerable_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00073974 File Offset: 0x00071B74
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResponseParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseParser.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0000ACA9 File Offset: 0x00008EA9
		public ResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponseBase_Public_Abstract_Virtual_New_IEnumerable_Match_Object_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
