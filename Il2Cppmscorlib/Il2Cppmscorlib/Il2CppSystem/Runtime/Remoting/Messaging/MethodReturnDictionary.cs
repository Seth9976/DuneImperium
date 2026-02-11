using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000305 RID: 773
	public class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x06002FC2 RID: 12226 RVA: 0x000F4E8C File Offset: 0x000F308C
		// Note: this type is marked as 'beforefieldinit'.
		static MethodReturnDictionary()
		{
			Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodReturnDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr);
			MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalReturnKeys");
			MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalExceptionKeys");
			MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, 100670869);
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x000F4EF8 File Offset: 0x000F30F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1384113, RefRangeEnd = 1384116, XrefRangeStart = 1384099, XrefRangeEnd = 1384113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodReturnDictionary(IMethodReturnMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000104B5 File Offset: 0x0000E6B5
		public MethodReturnDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000F4F44 File Offset: 0x000F3144
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x000104BE File Offset: 0x0000E6BE
		public unsafe static Il2CppStringArray InternalReturnKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000F4F6C File Offset: 0x000F316C
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x000104D0 File Offset: 0x0000E6D0
		public unsafe static Il2CppStringArray InternalExceptionKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeFieldInfoPtr_InternalReturnKeys;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeFieldInfoPtr_InternalExceptionKeys;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0;
	}
}
