using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.websocket
{
	// Token: 0x02000019 RID: 25
	public class TypedMessage : Object
	{
		// Token: 0x06000134 RID: 308 RVA: 0x000026A3 File Offset: 0x000008A3
		// Note: this type is marked as 'beforefieldinit'.
		static TypedMessage()
		{
			Il2CppClassPointerStore<TypedMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "TypedMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedMessage>.NativeClassPtr);
			TypedMessage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessage>.NativeClassPtr, 100663538);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009B18 File Offset: 0x00007D18
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000026DC File Offset: 0x000008DC
		public TypedMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
