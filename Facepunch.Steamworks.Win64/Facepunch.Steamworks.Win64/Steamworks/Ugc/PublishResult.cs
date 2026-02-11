using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D2 RID: 210
	[StructLayout(2)]
	public struct PublishResult
	{
		// Token: 0x06000D49 RID: 3401 RVA: 0x000558CC File Offset: 0x00053ACC
		// Note: this type is marked as 'beforefieldinit'.
		static PublishResult()
		{
			Il2CppClassPointerStore<PublishResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "PublishResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishResult>.NativeClassPtr);
			PublishResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishResult>.NativeClassPtr, "Result");
			PublishResult.NativeFieldInfoPtr_FileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishResult>.NativeClassPtr, "FileId");
			PublishResult.NativeFieldInfoPtr_NeedsWorkshopAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishResult>.NativeClassPtr, "NeedsWorkshopAgreement");
			PublishResult.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishResult>.NativeClassPtr, 100666490);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0005594C File Offset: 0x00053B4C
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishResult.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0000369D File Offset: 0x0000189D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishResult>.NativeClassPtr, ref this));
		}

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_FileId;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_NeedsWorkshopAgreement;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04001399 RID: 5017
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400139A RID: 5018
		[FieldOffset(8)]
		public PublishedFileId FileId;

		// Token: 0x0400139B RID: 5019
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool NeedsWorkshopAgreement;
	}
}
