using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.match
{
	// Token: 0x02000096 RID: 150
	public class IMakesPlayerMatchHistory<TGameResults> : Il2CppObjectBase where TGameResults : DBGGameResults
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x000380EC File Offset: 0x000362EC
		// Note: this type is marked as 'beforefieldinit'.
		static IMakesPlayerMatchHistory()
		{
			Il2CppClassPointerStore<IMakesPlayerMatchHistory<TGameResults>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IMakesPlayerMatchHistory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResults>.NativeClassPtr)) })).TypeHandle.value);
			IMakesPlayerMatchHistory<TGameResults>.NativeMethodInfoPtr_get_ResignedFromGame_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMakesPlayerMatchHistory<TGameResults>>.NativeClassPtr, 100664847);
			IMakesPlayerMatchHistory<TGameResults>.NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Abstract_Virtual_New_Dictionary_2_String_Int32_TGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMakesPlayerMatchHistory<TGameResults>>.NativeClassPtr, 100664848);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00038178 File Offset: 0x00036378
		public unsafe virtual bool ResignedFromGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMakesPlayerMatchHistory<TGameResults>.NativeMethodInfoPtr_get_ResignedFromGame_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000381C0 File Offset: 0x000363C0
		[CallerCount(0)]
		public unsafe virtual Dictionary<string, int> MakeMatchHistoryPlayerStats(TGameResults results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TGameResults).IsValueType)
				{
					TGameResults tgameResults = results;
					intPtr = ((tgameResults is string) ? IL2CPP.ManagedStringToIl2Cpp(tgameResults as string) : IL2CPP.Il2CppObjectBaseToPtr(tgameResults as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref results;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMakesPlayerMatchHistory<TGameResults>.NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Abstract_Virtual_New_Dictionary_2_String_Int32_TGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr4) : null;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00004E75 File Offset: 0x00003075
		public IMakesPlayerMatchHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_get_ResignedFromGame_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_MakeMatchHistoryPlayerStats_Public_Abstract_Virtual_New_Dictionary_2_String_Int32_TGameResults_0;
	}
}
