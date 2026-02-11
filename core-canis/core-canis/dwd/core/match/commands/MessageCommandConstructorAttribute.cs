using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.match.commands
{
	// Token: 0x0200016F RID: 367
	public class MessageCommandConstructorAttribute : Attribute
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x00068B48 File Offset: 0x00066D48
		// Note: this type is marked as 'beforefieldinit'.
		static MessageCommandConstructorAttribute()
		{
			Il2CppClassPointerStore<MessageCommandConstructorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "MessageCommandConstructorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCommandConstructorAttribute>.NativeClassPtr);
			MessageCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommandConstructorAttribute>.NativeClassPtr, "IsOverride");
			MessageCommandConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommandConstructorAttribute>.NativeClassPtr, 100666494);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00068BA0 File Offset: 0x00066DA0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageCommandConstructorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCommandConstructorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommandConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000959E File Offset: 0x0000779E
		public MessageCommandConstructorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00068BDC File Offset: 0x00066DDC
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x000095A7 File Offset: 0x000077A7
		public unsafe bool IsOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride)) = value;
			}
		}

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_IsOverride;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
