using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x02000054 RID: 84
	public class JoinGameError : NetworkMessageEvent
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x0000CD24 File Offset: 0x0000AF24
		// Note: this type is marked as 'beforefieldinit'.
		static JoinGameError()
		{
			Il2CppClassPointerStore<JoinGameError>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "JoinGameError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinGameError>.NativeClassPtr);
			JoinGameError.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameError>.NativeClassPtr, "Error");
			JoinGameError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameError>.NativeClassPtr, 100663434);
			JoinGameError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameError>.NativeClassPtr, 100663435);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000CD90 File Offset: 0x0000AF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193838, XrefRangeEnd = 1193843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JoinGameError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinGameError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinGameError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinGameError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003C3C File Offset: 0x00001E3C
		public JoinGameError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000CE10 File Offset: 0x0000B010
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00003C45 File Offset: 0x00001E45
		public unsafe string Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameError.NativeFieldInfoPtr_Error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameError.NativeFieldInfoPtr_Error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
