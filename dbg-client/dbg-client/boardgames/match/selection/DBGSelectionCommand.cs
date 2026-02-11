using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace boardgames.match.selection
{
	// Token: 0x02000263 RID: 611
	public class DBGSelectionCommand<T> : DBGSelectionCommand where T : class
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x00079CBC File Offset: 0x00077EBC
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionCommand()
		{
			Il2CppClassPointerStore<DBGSelectionCommand<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionCommand<T>>.NativeClassPtr);
			DBGSelectionCommand<T>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand<T>>.NativeClassPtr, 100667863);
			DBGSelectionCommand<T>.NativeMethodInfoPtr_get_Node_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand<T>>.NativeClassPtr, 100667864);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00079D50 File Offset: 0x00077F50
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 534669, RefRangeEnd = 534681, XrefRangeStart = 534668, XrefRangeEnd = 534669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionCommand<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand<T>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00079DAC File Offset: 0x00077FAC
		public new unsafe T Node
		{
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 534682, RefRangeEnd = 534853, XrefRangeStart = 534681, XrefRangeEnd = 534682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand<T>.NativeMethodInfoPtr_get_Node_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0000F1DD File Offset: 0x0000D3DD
		public DBGSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_get_Node_Protected_get_T_0;
	}
}
