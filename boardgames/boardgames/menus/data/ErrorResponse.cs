using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.data
{
	// Token: 0x02000152 RID: 338
	public class ErrorResponse : Object
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x00046218 File Offset: 0x00044418
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorResponse()
		{
			Il2CppClassPointerStore<ErrorResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus.data", "ErrorResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorResponse>.NativeClassPtr);
			ErrorResponse.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorResponse>.NativeClassPtr, "Message");
			ErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorResponse>.NativeClassPtr, 100665840);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00046270 File Offset: 0x00044470
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0000A18B File Offset: 0x0000838B
		public ErrorResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000462AC File Offset: 0x000444AC
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000A194 File Offset: 0x00008394
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorResponse.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorResponse.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
