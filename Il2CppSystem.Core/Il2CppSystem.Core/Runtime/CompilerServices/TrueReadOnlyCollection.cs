using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000111 RID: 273
	public sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T>
	{
		// Token: 0x06001057 RID: 4183 RVA: 0x00055F3C File Offset: 0x0005413C
		// Note: this type is marked as 'beforefieldinit'.
		static TrueReadOnlyCollection()
		{
			Il2CppClassPointerStore<TrueReadOnlyCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "TrueReadOnlyCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrueReadOnlyCollection<T>>.NativeClassPtr);
			TrueReadOnlyCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrueReadOnlyCollection<T>>.NativeClassPtr, 100666346);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00055FBC File Offset: 0x000541BC
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1027909, RefRangeEnd = 1027942, XrefRangeStart = 1027908, XrefRangeEnd = 1027909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrueReadOnlyCollection([Optional] Il2CppArrayBase<T> list)
		{
			if (list == null)
			{
				list = new Il2CppReferenceArray<T>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrueReadOnlyCollection<T>>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrueReadOnlyCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000070E9 File Offset: 0x000052E9
		public TrueReadOnlyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_0;
	}
}
