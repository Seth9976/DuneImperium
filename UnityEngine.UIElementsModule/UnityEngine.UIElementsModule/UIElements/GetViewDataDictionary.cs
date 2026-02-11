using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015E RID: 350
	public sealed class GetViewDataDictionary : MulticastDelegate
	{
		// Token: 0x06001981 RID: 6529 RVA: 0x000774F0 File Offset: 0x000756F0
		// Note: this type is marked as 'beforefieldinit'.
		static GetViewDataDictionary()
		{
			Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GetViewDataDictionary");
			GetViewDataDictionary.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr, 100667047);
			GetViewDataDictionary.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr, 100667048);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00077540 File Offset: 0x00075740
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetViewDataDictionary(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetViewDataDictionary.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0007759C File Offset: 0x0007579C
		[CallerCount(0)]
		public unsafe ISerializableJsonDictionary Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetViewDataDictionary.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializableJsonDictionary>(intPtr3) : null;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0000B9AE File Offset: 0x00009BAE
		public GetViewDataDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0000B9B7 File Offset: 0x00009BB7
		public static implicit operator GetViewDataDictionary(Func<ISerializableJsonDictionary> A_0)
		{
			return DelegateSupport.ConvertDelegate<GetViewDataDictionary>(A_0);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0000B9BF File Offset: 0x00009BBF
		public static GetViewDataDictionary operator +(GetViewDataDictionary A_0, GetViewDataDictionary A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GetViewDataDictionary>();
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0000B9CD File Offset: 0x00009BCD
		public static GetViewDataDictionary operator -(GetViewDataDictionary A_0, GetViewDataDictionary A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GetViewDataDictionary>();
			}
			return delegate2;
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0;
	}
}
