using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000123 RID: 291
	public class MonoLimitationAttribute : MonoTODOAttribute
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x00006353 File Offset: 0x00004553
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLimitationAttribute()
		{
			Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoLimitationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr);
			MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr, 100666773);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00084858 File Offset: 0x00082A58
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoLimitationAttribute(string comment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0000638C File Offset: 0x0000458C
		public MonoLimitationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
