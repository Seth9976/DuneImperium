using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000302 RID: 770
	public class MCMDictionary : MessageDictionary
	{
		// Token: 0x06002F62 RID: 12130 RVA: 0x000F36DC File Offset: 0x000F18DC
		// Note: this type is marked as 'beforefieldinit'.
		static MCMDictionary()
		{
			Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MCMDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr);
			MCMDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, "InternalKeys");
			MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, 100670811);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000F3734 File Offset: 0x000F1934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1383591, RefRangeEnd = 1383593, XrefRangeStart = 1383584, XrefRangeEnd = 1383591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MCMDictionary(IMethodMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x0001023F File Offset: 0x0000E43F
		public MCMDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000F3780 File Offset: 0x000F1980
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00010248 File Offset: 0x0000E448
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
