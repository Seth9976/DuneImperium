using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015F RID: 351
	public sealed class SavePersistentViewData : MulticastDelegate
	{
		// Token: 0x06001988 RID: 6536 RVA: 0x000775DC File Offset: 0x000757DC
		// Note: this type is marked as 'beforefieldinit'.
		static SavePersistentViewData()
		{
			Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SavePersistentViewData");
			SavePersistentViewData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr, 100667049);
			SavePersistentViewData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr, 100667050);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0007762C File Offset: 0x0007582C
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320969, XrefRangeEnd = 320972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavePersistentViewData(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePersistentViewData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00077688 File Offset: 0x00075888
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePersistentViewData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0000B9DE File Offset: 0x00009BDE
		public SavePersistentViewData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0000B9E7 File Offset: 0x00009BE7
		public static implicit operator SavePersistentViewData(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<SavePersistentViewData>(A_0);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0000B9EF File Offset: 0x00009BEF
		public static SavePersistentViewData operator +(SavePersistentViewData A_0, SavePersistentViewData A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SavePersistentViewData>();
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0000B9FD File Offset: 0x00009BFD
		public static SavePersistentViewData operator -(SavePersistentViewData A_0, SavePersistentViewData A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SavePersistentViewData>();
			}
			return delegate2;
		}

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
